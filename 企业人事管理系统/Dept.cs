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
    public partial class Dept : Form
    {
        public Dept()
        {
            InitializeComponent();
            sqlhelper = new Sqlhelper("server=.;database=rsgl;integrated security=true");

        }
        Sqlhelper sqlhelper;
        string comtext;
        DataSet ds;
        DataTable dt;

        private void button1_Click(object sender, EventArgs e)
        {
            comtext = "select * from [Dept] ";
            ds = sqlhelper.GetDataSet(comtext, "Dept");
            dt = ds.Tables["Dept"];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "部门编号";
            dataGridView1.Columns[1].HeaderText = "部门名称";
            dataGridView1.Columns[2].HeaderText = "部门级别";
            dataGridView1.Columns[3].HeaderText = "上级部门";
            dataGridView1.Columns[4].HeaderText = "人数上限";
            dataGridView1.Columns[5].HeaderText = "部门描述";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string comtext = "insert into [Dept] values('" + textBox4.Text.Trim() + "','" + textBox1.Text.Trim() + "','" + comboBox2.Text.Trim() + "','" + comboBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "')"; 
            if (sqlhelper.ExecuteNoQuery(comtext))
            {
                MessageBox.Show("添加成功！！");
            }
            else
                MessageBox.Show("部门添加失败！");
        }
    }
}
