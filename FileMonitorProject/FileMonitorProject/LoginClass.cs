using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileMonitorProject
{
    class LoginClass
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public LoginClass(string username, string password)
        {
            this.password = password;
            this.username = username;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}", username, password);
        }
    }
}
