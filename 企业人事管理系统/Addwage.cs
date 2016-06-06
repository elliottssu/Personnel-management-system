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
    public partial class Addwage : Form
    {
        public Addwage()
        {
            InitializeComponent();
            sqlhelper = new Sqlhelper("server=.;database=rsgl;integrated security=true");
        }
        Sqlhelper sqlhelper;
        private void button1_Click(object sender, EventArgs e)
        {
            string comtext = "insert into [Wage] values('" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox4.Text.Trim() + "','" + textBox5.Text.Trim() + "','" + textBox6.Text.Trim() + "','" + textBox7.Text.Trim() + "','" + textBox8.Text.Trim() + "','" + textBox9.Text.Trim() + "','" + textBox10.Text.Trim() + "','" + textBox11.Text.Trim() + "','" + textBox12.Text.Trim() + "','" + textBox13.Text.Trim() + "','" + textBox14.Text.Trim() + "','" + textBox15.Text.Trim() + "','" + textBox16.Text.Trim() + "')";
            if (sqlhelper.ExecuteNoQuery(comtext))
            {
                MessageBox.Show("薪酬登记成功");
            }
            else
                MessageBox.Show("登记失败！");
        }
    }
}
