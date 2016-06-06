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
    public partial class Personpassword : Form
    {
        public Personpassword()
        {
            InitializeComponent();
            sqlhelper = new Sqlhelper("server=.;database=rsgl;integrated security=true");

        }
        Sqlhelper sqlhelper;
        string comtext;

        private void button1_Click(object sender, EventArgs e)
        {
         string pwd = Land.pwd;
            if (textBox1.Text.Trim() == pwd.ToString())
            {
                comtext = "update  [user] set Userpwd='" + textBox2.Text.Trim() + "'";
                if (sqlhelper.ExecuteNoQuery(comtext))
                {
                    MessageBox.Show("密码修改成功！");
                }
                else
                    MessageBox.Show("密码修改失败！");
            }
            else
                MessageBox.Show("密码错误请重新输入！");
        }
    }
}
