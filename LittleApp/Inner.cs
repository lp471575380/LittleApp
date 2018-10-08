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
    public partial class Inner : Form
    {
        public Inner()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionOptions options = new ConnectionOptions();
            options.Username = "用户名";
            options.Password = "密码";
            ManagementScope scope = new ManagementScope("\\\\" + "192.168.144.66" + "\\root\\cimv2", options);
            //用给定管理者用户名和口令连接远程的计算机           
            scope.Connect();
            System.Management.ObjectQuery oq = new System.Management.ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher query1 = new ManagementObjectSearcher(scope, oq);
            //得到WMI控制 
            ManagementObjectCollection queryCollection1 = query1.Get();
            foreach (ManagementObject mo in queryCollection1)
            {
                string[] ss = { "" };
                //重启远程计算机 
                mo.InvokeMethod("Reboot", ss);              
            }
            MessageBox.Show("重启成功，请耐心等待");
        }
    }
}
