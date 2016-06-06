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
    public partial class Personwage : Form
    {
        public Personwage()
        {
            InitializeComponent();
            sqlhelper = new Sqlhelper("server=.;database=rsgl;integrated security=true");

        }
        Sqlhelper sqlhelper;
        string comtext;
        DataSet ds;

        private void Personwage_Load(object sender, EventArgs e)
        {
            string name = Land.name;
            comtext = "select * from [Wage] where name='" + name + "' ";
            
            if (sqlhelper.findname(comtext))
            {

                ds = sqlhelper.GetDataSet(comtext, "Wage");
                label1.Text = ds.Tables[0].Rows[0][3].ToString();//将表中的第一行第四列的数据显示在label上
                label2.Text = ds.Tables[0].Rows[0][4].ToString();
                label3.Text = ds.Tables[0].Rows[0][5].ToString();
                label4.Text = ds.Tables[0].Rows[0][6].ToString();
                label5.Text = ds.Tables[0].Rows[0][7].ToString();
                label6.Text = ds.Tables[0].Rows[0][8].ToString();
                label7.Text = ds.Tables[0].Rows[0][9].ToString();
                label18.Text = ds.Tables[0].Rows[0][10].ToString();
                label33.Text = ds.Tables[0].Rows[0][11].ToString();
                label35.Text = ds.Tables[0].Rows[0][12].ToString();
                label36.Text = ds.Tables[0].Rows[0][13].ToString();
                label37.Text = ds.Tables[0].Rows[0][14].ToString();
            }
            else
            {
                MessageBox.Show("请检查员工姓名是否存在！");
               
            }
        }
    }
}
