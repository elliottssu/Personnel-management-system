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
    public partial class Kaoqin : Form
    {
        public Kaoqin()
        {
            InitializeComponent();
            sqlhelper = new Sqlhelper("server=.;database=rsgl;integrated security=true");

        }
        Sqlhelper sqlhelper;
        string comtext;
        DataSet ds;
        DataTable dt;

        private void Kaoqin_Load(object sender, EventArgs e)
        {
            comtext = "select * from [Kaoqin] ";
            ds = sqlhelper.GetDataSet(comtext, "Kaoqin");
            dt = ds.Tables["Kaoqin"];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "考勤编号";
            dataGridView1.Columns[1].HeaderText = "员工姓名";
            dataGridView1.Columns[2].HeaderText = "上午上班时间";
            dataGridView1.Columns[3].HeaderText = "上午下班时间";
            dataGridView1.Columns[4].HeaderText = "下午上班时间";
            dataGridView1.Columns[5].HeaderText = "下午下班时间";
            dataGridView1.Columns[6].HeaderText = "日期";
           
        }
    }
}
