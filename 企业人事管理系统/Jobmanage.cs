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
    public partial class Jobmanage : Form
    {
        public Jobmanage()
        {
            InitializeComponent();
            sqlhelper = new Sqlhelper("server=.;database=rsgl;integrated security=true");
        }
        Sqlhelper sqlhelper;
        string comtext;
        DataSet ds;

        private void Jobmanage_Load(object sender, EventArgs e)
        {
            
               comtext = "select * from [Job] ";
                ds = sqlhelper.GetDataSet(comtext, "Job");
                bindingSource1.DataSource = ds;
                bindingSource1.DataMember = "Job";
                bindingNavigator1.BindingSource = bindingSource1;

                textBox1.DataBindings.Add("Text", bindingSource1, "id");
                textBox2.DataBindings.Add("Text", bindingSource1, "zhiwei");
                textBox3.DataBindings.Add("Text", bindingSource1, "gongxing");
                textBox4.DataBindings.Add("Text", bindingSource1, "sex");
                textBox5.DataBindings.Add("Text", bindingSource1, "hun");
                textBox6.DataBindings.Add("Text", bindingSource1, "youxiao");
                textBox7.DataBindings.Add("Text", bindingSource1, "zhaopin");
                textBox8.DataBindings.Add("Text", bindingSource1, "xinjin");
                textBox9.DataBindings.Add("Text", bindingSource1, "xueli");
                textBox10.DataBindings.Add("Text", bindingSource1, "zhuanye");
                textBox11.DataBindings.Add("Text", bindingSource1, "linkman");
                richTextBox1.DataBindings.Add("Text", bindingSource1, "zhuanye");
                textBox12.DataBindings.Add("Text", bindingSource1, "name");
                dateTimePicker1.DataBindings.Add("Text", bindingSource1, "time");

           
            }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请确定是否修改过某项！");
            string comtext = "update Job set id='" + textBox1.Text.Trim() + "',zhiwei='" + textBox2.Text.Trim() + "',gongxing='" + textBox3.Text.Trim() + "',sex='" + textBox4.Text.Trim() + "',hun='" + textBox5.Text.Trim() + "',youxiao='" + textBox6.Text.Trim() + "',zhaopin='" + textBox7.Text.Trim() + "',xinjin='" + textBox8.Text.Trim() + "',xueli='" + textBox9.Text.Trim() + "',zhuanye='" + textBox10.Text.Trim() + "',linkman='" + textBox11.Text.Trim() + "',zhuanye='" + richTextBox1.Text.Trim() + "',name='" + textBox12.Text.Trim() + "',time='" + dateTimePicker1.Value.ToString() + "')";
            if (sqlhelper.ExecuteNoQuery(comtext))
            {
                MessageBox.Show("修改招聘信息成功！");
            }
            else
                MessageBox.Show("修改失败！");
        }
        }
        }
    
