using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace 企业人事管理系统
{
    public partial class Main : Form
    {
       
        public Main()
        {
        
            InitializeComponent();
            sqlhelper = new Sqlhelper("server=.;database=rsgl;integrated security=true");
        }
        Sqlhelper sqlhelper;
      

        private void Main_Load(object sender, EventArgs e)
        {
            label2.Text = Land.name;
           
             if (Land.gl == "管理员")
            {
                
                个人管理ToolStripMenuItem.Enabled = false;
            }
                
                else
                {
                人事管理ToolStripMenuItem.Enabled = false;
                薪酬管理ToolStripMenuItem.Enabled = false;
                招聘管理ToolStripMenuItem.Enabled = false;
                系统管理ToolStripMenuItem.Enabled = false;
                }
            
             }

        private void 工作任务查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personwork a = new Personwork();
            a.MdiParent = this;
            a.Show();
        }

        private void 递交假期申请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Leaveput a = new Leaveput();
            a.MdiParent = this;
            a.Show();
        }

        private void 查询假期申请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Leavefand a = new Leavefand();
            a.MdiParent = this;
            a.Show();
        }

        private void 个人信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personinformation a = new Personinformation();
            a.MdiParent = this;
            a.Show();
        }

        private void 个人薪资查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personwage a = new Personwage();
            a.MdiParent = this;
            a.Show();
        }

        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Personpassword a = new Personpassword();
            a.MdiParent = this;
            a.Show();
        }

        private void 部门设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dept  a = new Dept();
            a.MdiParent = this;
            a.Show();
        }

        private void 人事设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Renshi a = new Renshi();
            a.MdiParent = this;
            a.Show();
        }

        private void 添加员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addemployee a = new Addemployee();
            a.MdiParent = this;
            a.Show();
        }

        private void 查询员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Searchemployee a = new Searchemployee();
            a.MdiParent = this;
            a.Show();
        }

        private void 修改员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changeemployee a = new Changeemployee();
            a.MdiParent = this;
            a.Show();
        }

        private void 布置工作任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Workput a = new Workput();
            a.MdiParent = this;
            a.Show();
        }

        private void 查看工作任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workfand a = new Workfand();
            a.MdiParent = this;
            a.Show();
        }

        private void 考勤工作管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Kaoqin a = new Kaoqin();
            a.MdiParent = this;
            a.Show();
        }

        private void 薪酬登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addwage a = new Addwage();
            a.MdiParent = this;
            a.Show();
        }

        private void 薪酬修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changewage a = new Changewage();
            a.MdiParent = this;
            a.Show();
        }

        private void 薪酬查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Searchwage  a = new Searchwage ();
            a.MdiParent = this;
            a.Show();
        }

        private void 添加招聘信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jobput a = new Jobput ();
            a.MdiParent = this;
            a.Show();
        }

        private void 管理招聘信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Jobmanage  a = new Jobmanage ();
            a.MdiParent = this;
            a.Show();
        }

        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adduser  a = new  Adduser();
            a.MdiParent = this;
            a.Show();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Usermanage  a = new Usermanage ();
            a.MdiParent = this;
            a.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }
        }
    }
