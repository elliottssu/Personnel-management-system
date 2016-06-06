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
    public partial class Leavefand : Form
    {
        public Leavefand()
        {
            InitializeComponent();
               sqlhelper = new Sqlhelper("server=.;database=rsgl;integrated security=true");

        }
        Sqlhelper sqlhelper;
        string comtext;
        DataSet ds;
        DataTable dt;

        private void Leavefand_Load(object sender, EventArgs e)
        {
            string name = Land.name;
            comtext = "select * from [Leave] where name='" + name + "' ";
            
            ds = sqlhelper.GetDataSet(comtext, "Leave");
            dt = ds.Tables["Leave"];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "员工编号";
            dataGridView1.Columns[1].HeaderText = "员工姓名";
            dataGridView1.Columns[2].HeaderText = "开始时间";
            dataGridView1.Columns[3].HeaderText = "结束时间";
            dataGridView1.Columns[4].HeaderText = "是否半天";
            dataGridView1.Columns[5].HeaderText = "请假原因";
            dataGridView1.Columns[6].HeaderText = "请假天数";
            dataGridView1.Columns[7].HeaderText = "所属部门";
        }
    }
}
