using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySQLDriverCS;
using MySql.Data.MySqlClient;

namespace 葡萄霜霉病防控测试系统1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //String sql = String.Format("select count(8) from Login where username='{0}' and password ='{1}'", name, pwd);

            if (name == "ptsmb" && pwd == "ptsmb")
            {
                //  MessageBox.Show("登录成功");
               // MessageBox.Show("Dear Student:登录失败，请重新输入");
                ////内存中创建窗体2对象
                this.DialogResult = DialogResult.OK;
                //this.Hide();
                //// this.Dispose();
                //葡萄霜霉病防控系统 frm2 = new 葡萄霜霉病防控系统();
                ////展示当前窗体
                //frm2.Show();
            }
            else {
                MessageBox.Show("请输入用户名和密码！");
                txtName.Clear();
                txtPwd.Clear();
            }
            //创建SqlCommand对象
            //MySQLCommand command = new MySQLCommand(sql, conn);
            //int num = Convert.ToInt32(command.ExecuteScalar());
            //try
            //{
            //    if (num > 0)
            //    {
                   
            //    }
            //    else
            //    {
            //        MessageBox.Show("登录失败");
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("错误异常");
            //}
            //finally {
            //    conn.Close();
            //}
            ////
             
        }

        private void Login_Load(object sender, EventArgs e)
        {

            //MySQLCommand commn = new MySQLCommand("set names gb2312", conn);
            //commn.ExecuteNonQuery();

            //string sql = "select * from exchange ";
            //MySQLDataAdapter mda = new MySQLDataAdapter(sql, conn);

            //DataSet ds = new DataSet();
            //mda.Fill(ds, "table1");

            //this.dataGrid1.DataSource = ds.Tables["table1"];
            //conn.Close();
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.btnLogin.Focus();
                this.btnLogin.PerformClick();
            }
        }
    }
}
