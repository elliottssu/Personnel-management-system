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
    public partial class Workput : Form
    {
        public Workput()
        {
            InitializeComponent();
            sqlhelper = new Sqlhelper("server=.;database=rsgl;integrated security=true");
        }
        Sqlhelper sqlhelper;

        private void button1_Click(object sender, EventArgs e)
        {
            string comtext = "insert into [Work] values('" + textBox4.Text.Trim() + "','" + textBox1.Text.Trim() + "','" + richTextBox1.Text.Trim() + "','" + textBox6.Text.Trim() + "','" + textBox5.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox7.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox8.Text.Trim() + "')"; 
            if (sqlhelper.ExecuteNoQuery(comtext))
            {
                MessageBox.Show("工作内容递交成功！");
            }
            else
                MessageBox.Show("递交失败失败！");
        }
    }
}
