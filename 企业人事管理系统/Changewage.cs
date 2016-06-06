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
    public partial class Changewage : Form
    {
        public Changewage()
        {
            InitializeComponent();
            sqlhelper = new Sqlhelper("server=.;database=rsgl;integrated security=true");
        }
        Sqlhelper sqlhelper;
        string comtext;
        DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text.Trim();
            comtext = "select * from [Wage] where name='" + name + "'";
            if (sqlhelper.findname(comtext))
            {
                ds = sqlhelper.GetDataSet(comtext, "Wage");
                bindingSource1.DataSource = ds;
                bindingSource1.DataMember = "Wage";
                textBox2.DataBindings.Add("Text", bindingSource1, "rixin");
                textBox1.DataBindings.Add("Text", bindingSource1, "benxin");
                textBox4.DataBindings.Add("Text", bindingSource1, "jiangjin");
                textBox5.DataBindings.Add("Text", bindingSource1, "jiari");
                textBox6.DataBindings.Add("Text", bindingSource1, "quanqin");
                textBox7.DataBindings.Add("Text", bindingSource1, "jiaban");
                textBox8.DataBindings.Add("Text", bindingSource1, "benqi");
                textBox9.DataBindings.Add("Text", bindingSource1, "fuli");
                textBox10.DataBindings.Add("Text", bindingSource1, "huoshi");
                textBox11.DataBindings.Add("Text", bindingSource1, "suode");
                textBox12.DataBindings.Add("Text", bindingSource1, "jiezhi");
                textBox13.DataBindings.Add("Text", bindingSource1, "shifa");
                MessageBox.Show("请在方框内输入要更改的信息！");
            }
            else
            {
                MessageBox.Show("请检查员工姓名是否存在！");
                textBox3.Text = "";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
             string comtext = "update Wage set rixin='" + textBox2.Text.Trim() + "',benxin='" + textBox1.Text.Trim() + "',jiangjin='" + textBox4.Text.Trim() + "',jiari='" + textBox5.Text.Trim() + "',quanqin='" + textBox6.Text.Trim() + "',jiaban='" + textBox7.Text.Trim() + "',benqi='" + textBox8.Text.Trim() + "',fuli='" + textBox9.Text.Trim() + "',huoshi='" + textBox10.Text.Trim() + "',suode='" + textBox11.Text.Trim() + "',jiezhi='" + textBox12.Text.Trim() + "',shifa='" + textBox13.Text.Trim() + "'";
            if (sqlhelper.ExecuteNoQuery(comtext))
            {
                MessageBox.Show("修改薪酬信息成功！");
            }
            else
                MessageBox.Show("修改失败！！");
        }

        }

       
    }

