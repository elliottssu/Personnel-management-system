using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace 企业人事管理系统
{
    public partial class Usermanage : Form
    {
        public Usermanage()
        {
            InitializeComponent();
            sqlhelper = new Sqlhelper("server=.;database=rsgl;integrated security=true");

        }
        Sqlhelper sqlhelper;
        string comtext;
        DataSet ds;
        DataTable dt;

        private void Usermanage_Load(object sender, EventArgs e)
        {
            comtext = "select * from [user]" ;

            ds = sqlhelper.GetDataSet(comtext, "user");
            dt = ds.Tables["user"];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "用户编号";
            dataGridView1.Columns[1].HeaderText = "用户名";
            dataGridView1.Columns[2].HeaderText = "密码";
            dataGridView1.Columns[3].HeaderText = "用户姓名";
            dataGridView1.Columns[4].HeaderText = "注册时间";
            dataGridView1.Columns[5].HeaderText = "是否管理员";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确定要删除该列吗？");
            DataTable dt = ds.Tables[0];
            if (dataGridView1.Rows.Count <= 0 ||
                dataGridView1.SelectedRows.Count <= 0) return;

            //定义一个数组保存所选中的行 
            int[] sel_rows = new int[dataGridView1.SelectedRows.Count];
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                sel_rows[i] = dataGridView1.SelectedRows[i].Index;
            }

            //根据数组选择所得到的行号删除数据表 
            for (int i = 0; i < sel_rows.Length; i++)
            {
                dt.Rows[sel_rows[i]].Delete();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确实要修改数据库吗？", "决策提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //this.tbTableAdapter.Update(this.abcDataSet2.tb);

                DataTable dt = dataGridView1.DataSource as DataTable;
                if (dt != null)
                {
                    
                        using (SqlConnection con = new SqlConnection("server=.;database=rsgl;integrated security=true"))
                        {
                            SqlDataAdapter da = new SqlDataAdapter("select * from user", con);
                            
                        }
                    }
                   
              
                MessageBox.Show("成功修改员工信息！", "恭喜");
            }
            else
            {
                MessageBox.Show("放弃修改数据库！", "系统提示");
            }
        }
    }
}
