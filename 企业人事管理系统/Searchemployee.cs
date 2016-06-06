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
    public partial class Searchemployee : Form
    {
        public Searchemployee()
        {
            InitializeComponent();
            sqlhelper = new Sqlhelper("server=.;database=rsgl;integrated security=true");
           
        }
        Sqlhelper sqlhelper;
        string comtext;
        DataSet ds;
        DataTable dt;
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           if (radioButton1.Checked)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
            }
            else
                textBox1.Enabled = false; textBox1.Text = "";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Enabled = true; textBox1.Enabled = false;
            }
            else
                textBox2.Enabled = false; textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)  //查询
        {
            string strcond = "";
            if (radioButton1.Checked)
                if (textBox1.Text.Trim() != "")
                    strcond = "id like '%" + textBox1.Text.Trim()+"%'";
                else
                {
                    MessageBox.Show("请输入查询条件");
                    textBox1.Focus();
                    return;
                }
            if (radioButton2.Checked)
                if (textBox2.Text.Trim() != "")
                    strcond = "name like '%" + textBox2.Text.Trim() + "%'";
                else
                {
                    MessageBox.Show("请输入查询条件");
                    textBox2.Focus();
                    return;
                }
             comtext = "select * from [Employee] where " + strcond;

             ds = sqlhelper.GetDataSet(comtext ,"Employee");
            dt=ds.Tables["Employee"];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "员工编号";
            dataGridView1.Columns[1].HeaderText = "员工姓名"; 
            dataGridView1.Columns[2].HeaderText = "英文名";
            dataGridView1.Columns[3].HeaderText = "年龄";
            dataGridView1.Columns[4].HeaderText = "性别";
            dataGridView1.Columns[5].HeaderText = "出生日期";
            dataGridView1.Columns[6].HeaderText = "籍贯";
            dataGridView1.Columns[7].HeaderText = "现居地址";
            dataGridView1.Columns[8].HeaderText = "电话";
            dataGridView1.Columns[9].HeaderText = "手机";
            dataGridView1.Columns[10].HeaderText = "进公司时间";
            dataGridView1.Columns[11].HeaderText = "是否正式员工";
            dataGridView1.Columns[12].HeaderText = "合同";
            dataGridView1.Columns[13].HeaderText = "合同期限";
            dataGridView1.Columns[14].HeaderText = "合同有效期时间";
            dataGridView1.Columns[15].HeaderText = "职位";
            dataGridView1.Columns[16].HeaderText = "所属部门";
            dataGridView1.Columns[17].HeaderText = "职位是否空缺";
            dataGridView1.Columns[18].HeaderText = "电子邮箱";
            dataGridView1.Columns[19].HeaderText = "学历";
            dataGridView1.Columns[20].HeaderText = "毕业院校";
            dataGridView1.Columns[21].HeaderText = "专业";
            dataGridView1.Columns[22].HeaderText = "政治面貌";
            dataGridView1.Columns[23].HeaderText = "婚姻状况"; 
            dataGridView1.Columns[24].HeaderText = "工作经历";
            dataGridView1.Columns[25].HeaderText = "已参加工作时间";
        }

        private void button2_Click(object sender, EventArgs e) //退出
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
