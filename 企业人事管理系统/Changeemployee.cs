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
    public partial class Changeemployee : Form
    {
        public Changeemployee()
        {
            InitializeComponent();
            sqlhelper = new Sqlhelper("server=.;database=rsgl;integrated security=true");
        }
        Sqlhelper sqlhelper;
        string comtext;
        DataSet ds;
        private void Changeemployee_Load(object sender, EventArgs e)
        {
            textBox25.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
           string name = textBox25.Text.Trim();
            comtext  = "select * from [Employee] where name='" + name  + "'";
             if (sqlhelper.findname(comtext))
            {
            ds = sqlhelper.GetDataSet(comtext, "Employee");
            bindingSource1.DataSource = ds;
            bindingSource1.DataMember = "Employee";
            textBox1.DataBindings.Add("Text", bindingSource1, "id");
            textBox2.DataBindings.Add("Text", bindingSource1, "name");
            textBox3.DataBindings.Add("Text", bindingSource1, "ename");
            comboBox1.DataBindings.Add("Text", bindingSource1, "age");
            comboBox2.DataBindings.Add("Text", bindingSource1, "sex");
            textBox4.DataBindings.Add("Text", bindingSource1, "chusheng");
            textBox5.DataBindings.Add("Text", bindingSource1, "jiguan");
            textBox6.DataBindings.Add("Text", bindingSource1, "xianzhi");
            textBox7.DataBindings.Add("Text", bindingSource1, "tel");
            textBox8.DataBindings.Add("Text", bindingSource1, "hander");
           // textBox9.DataBindings.Add("Text", bindingSource1, "jingongsi");
            textBox10.DataBindings.Add("Text", bindingSource1, "zhengshi");
            textBox11.DataBindings.Add("Text", bindingSource1, "hetong");
            textBox12.DataBindings.Add("Text", bindingSource1, "qixian");
            //textBox13.DataBindings.Add("Text", bindingSource1, "youxiaoqi");
            textBox14.DataBindings.Add("Text", bindingSource1, "zhiwei");
            textBox15.DataBindings.Add("Text", bindingSource1, "suoshu");
            textBox16.DataBindings.Add("Text", bindingSource1, "kong");
            textBox17.DataBindings.Add("Text", bindingSource1, "email");
            textBox18.DataBindings.Add("Text", bindingSource1, "xueli");
            textBox19.DataBindings.Add("Text", bindingSource1, "school");
            textBox20.DataBindings.Add("Text", bindingSource1, "zhuanye");
            textBox21.DataBindings.Add("Text", bindingSource1, "mianmao");
            textBox22.DataBindings.Add("Text", bindingSource1, "hun");
            textBox23.DataBindings.Add("Text", bindingSource1, "work");
            textBox24.DataBindings.Add("Text", bindingSource1, "uj");
            MessageBox.Show("请在方框内输入要更改的信息！");
            }
             else
             {
                 MessageBox.Show("请检查员工姓名是否存在！");
                 textBox25.Text = "";
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          string comtext = "update Employee set ename='" + textBox3.Text.Trim() + "',age='" + comboBox1.Text.Trim() + "',sex='" + comboBox2.Text.Trim() + "',chusheng='" + textBox4.Text.Trim() + "',jiguan='" + textBox5.Text.Trim() + "',xianzhi='" + textBox6.Text.Trim() + "',tel='" + textBox7.Text.Trim() + "',hander='" + textBox8.Text.Trim() + "',jinggongsi='" + textBox9.Text.Trim() + "',zhengshi='" + textBox10.Text.Trim() + "',hetong='" + textBox11.Text.Trim() + "',qixian='" + textBox12.Text.Trim() + "',youxiaoqi='" + textBox13.Text.Trim() + "',zhiwei='" + textBox14.Text.Trim() + "',suoshu='" + textBox15.Text.Trim() + "',kong'" + textBox16.Text.Trim() + "',email='" + textBox17.Text.Trim() + "',xueli='" + textBox18.Text.Trim() + "',school='" + textBox19.Text.Trim() + "',zhuanye='" + textBox20.Text.Trim() + "',mianmao='" + textBox21.Text.Trim() + "',hun='" + textBox22.Text.Trim() + "',work='" + textBox23.Text.Trim() + "',uj='" + textBox24.Text.Trim() + "'";
            if (sqlhelper.ExecuteNoQuery(comtext))
            {
                MessageBox.Show("更改员工信息成功！");
            }
            else
                MessageBox.Show("更改员工信息失败！");
        }

      
    }
}
