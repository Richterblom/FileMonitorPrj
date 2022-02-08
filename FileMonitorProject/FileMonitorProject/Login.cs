using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//have to use using system IO to see streaReader
using System.IO;
//also need windows.forms for exception handling
using System.Windows.Forms;



namespace FileMonitorProject
{
    public partial class Login : Form
    {
        public static string mainUser;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
           // Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password, exist;
            username = txtUsername.Text;
            password = txtPassword.Text;
            exist = "False";
            string Check = username + "\t" + password;

            List<LoginClass> loginClass = FileHandler.Detail();

            for (int i = 0; i < loginClass.Count; i++)
            {
                string info = Convert.ToString(loginClass[i]);
                if (Check == info)
                {
                    exist = "True";
                }
            }
            if (exist == "True")
            {
                mainUser = username;
                this.Hide();
                FileMonitor fM = new FileMonitor();
                fM.Show();
                MessageBox.Show(mainUser , "Logged in as", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Incorrect username or password, Please check your details", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        //displays and hides password
        private void cbShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowHide.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}

