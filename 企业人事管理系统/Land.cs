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
    public partial class Land : Form
    {

        public Land()
        {
            InitializeComponent();

        }

        public static string uid, pwd, gl,name;


        private void button1_Click(object sender, EventArgs e)
        {
            gl = comboBox1.SelectedItem.ToString();

            uid = textBox1.Text.Trim();
            pwd = textBox2.Text.Trim();
            string strcom = "select * from [user] where Username='" + uid + "'";

            string constr = "server=.;database=rsgl;integrated security=true";
            SqlConnection conn = new SqlConnection(constr);

            conn.Open();
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.Connection = conn;
            sqlcom.CommandText = strcom;
            SqlDataReader da = sqlcom.ExecuteReader();
            ;
            //获取用户密码，并且得到权限
            if (da.Read())
            {
                if (textBox2.Text.Trim() == da["Userpwd"].ToString().Trim())
                {
                    name = da["name"].ToString().Trim();
                    gl = da["sfgly"].ToString().Trim();
                    if (comboBox1.Text.Trim() == da["sfgly"].ToString().Trim())
                    {
                       
                        this.Hide();
                        Main main = new Main();
                        main.Show();

                    }
                    else
                        MessageBox.Show("用户名或密码错误！");


                }
                else
                    MessageBox.Show("用户名或密码错误！");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
