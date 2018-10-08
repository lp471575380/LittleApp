using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace LittleApp
{
    public partial class Remote : Form
    {
        public Remote()
        {
            InitializeComponent();
        }

        private void 远程连接小程序_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取数据
            //从TextBox中获取用户输入信息
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;

            //验证信息
            if(username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("用户名或者密码不能为空！");
            }
            else
            {
             //若不为空，验证用户名和密码是否和数据库匹配
                if (username.Equals("admin") && password.Equals("123"))
                {
                    MessageBox.Show("登录成功！");
                    Inner inner = new Inner();
                    inner.Show();
                    this.Hide();    
                    

                }
                else
                {
                    MessageBox.Show("用户名或者密码错误！");
                }
             
                      
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
 