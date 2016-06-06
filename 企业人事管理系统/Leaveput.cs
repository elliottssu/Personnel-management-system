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
    public partial class Leaveput : Form
    {
        public Leaveput()
        {
            InitializeComponent();
            sqlhelper = new Sqlhelper("server=.;database=rsgl;integrated security=true");
        }
        Sqlhelper sqlhelper;
        private void button1_Click(object sender, EventArgs e)
        {
            string comtext = "insert [Leave] values('" + textBox1.Text.Trim() + "','" + dateTimePicker1.Value.ToString()  + "','" + dateTimePicker2.Value.ToString() + "','" + richTextBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "')";
            if (sqlhelper.ExecuteNoQuery(comtext))
            {
                MessageBox.Show("递交失败！");
            }
            else
                MessageBox.Show("假期申请递交成功！");
        }
    }
}
