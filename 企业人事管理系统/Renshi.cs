using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 企业人事管理系统
{
    public partial class Renshi : Form
    {
        public Renshi()
        {
            InitializeComponent();
            sqlhelper = new Sqlhelper("server=.;database=rsgl;integrated security=true");

        }
        Sqlhelper sqlhelper;
        string comtext;
        DataSet ds;
        DataTable dt;
        

        private void Renshi_Load(object sender, EventArgs e)
        {
            comtext = "select * from [Renshi]";

            ds = sqlhelper.GetDataSet(comtext, "Renshi");
            dt = ds.Tables["Renshi"];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "人员名称";
            dataGridView1.Columns[1].HeaderText = "人员性别";
            dataGridView1.Columns[2].HeaderText = "所属职务";
            dataGridView1.Columns[3].HeaderText = "所属部门";

        }

        //删除选中行
        private void button1_Click(object sender, EventArgs e)
        {
          if (dataGridView1.SelectedRows.Count == 0)
          { 
              MessageBox.Show("请先选择要删除的记录！");
              return ;
          }
          DialogResult result = MessageBox.Show("是否要删除该记录？");
          string name;
          Renshi s = new Renshi();
          s.Name = name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
         
          dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
        }
    }
}
