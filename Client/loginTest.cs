using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using MySQLDriverCS;
using System.IO;
using System.Configuration;
using MySql.Data.MySqlClient;

string MyConnectionString = "Server=localhost;Database=testdb;Uid=root;Pwd=123456;";
MySqlConnection connection = new MySqlConnection(MyConnectionString);
MySqlCommand cmd = connection.CreateCommand();
MySqlDataReader reader = null;      //查询结果读取器
string name = txtName.Text.Trim();
string pwd = txtPwd.Text;
int32 euqalFlag = 0;

connection.Open();//连接数据库
			cmd.CommandText = "select user_Password from tb_user where user_Name = " + name;
			reader = cmd.ExecuteReader();
			while(reader.Read()){
				if(reader[0] == pwd)
				{
					euqalFlag = 1;
				}
			}
			if(equalFlag) {
				this.DialogResult = DialogResult.OK;
			}