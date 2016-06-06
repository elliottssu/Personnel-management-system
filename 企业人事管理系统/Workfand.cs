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
    public partial class Workfand : Form
    {
        public Workfand()
        {
            InitializeComponent();
            sqlhelper = new Sqlhelper("server=.;database=rsgl;integrated security=true");

        }
        Sqlhelper sqlhelper;
        string comtext;
        DataSet ds;
        DataTable dt;

        private void Workmanage_Load(object sender, EventArgs e)
        {
            comtext = "select * from [Work] ";
            ds = sqlhelper.GetDataSet(comtext, "Work");
            dt = ds.Tables["Work"];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "任务名称";
            dataGridView1.Columns[1].HeaderText = "任务内容";
            dataGridView1.Columns[2].HeaderText = "完成者";
            dataGridView1.Columns[3].HeaderText = "任务期限";
            
        }
    }
}
