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
    public partial class Adduser : Form
    {
        public Adduser()
        {
            InitializeComponent();
            sqlhelper = new Sqlhelper("server=.;database=rsgl;integrated security=true");
        }
        Sqlhelper sqlhelper;
     
        
        private void button1_Click(object sender, EventArgs e)
        {

            string comtext = "insert into [user] values('" + textBox4.Text.Trim() + "','" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox5.Text.Trim() +  "','" + comboBox2.Text.Trim() + "'";
            if (sqlhelper.ExecuteNoQuery(comtext))
            {
                MessageBox.Show("添加失败！");
            }
            else
                MessageBox.Show("员工信息添加成功！");
        }
    }
}
