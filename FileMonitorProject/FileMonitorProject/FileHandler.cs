using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//have to use using system IO to see streaReader
using System.IO;
//also need windows.forms for exception handling
using System.Windows.Forms;

namespace FileMonitorProject
{
    class FileHandler
    {
        static string fileName = "Passwords.txt";
        public static List<LoginClass> Detail()
        {
            List<LoginClass> loginClass = new List<LoginClass>();//must have 
            StreamReader read = null;
            try
            {
                if (File.Exists(fileName))
                {
                    read = new StreamReader(fileName);
                    string line;
                    while ((line = read.ReadLine()) != null)
                    {
                        string[] info = line.Split('#');
                        loginClass.Add(new LoginClass(info[0], info[1]));
                    }
                }
                else
                {
                    throw new CustomMessage("File Does not exist");
                }
            }
            catch (CustomMessage ea)
            {
                MessageBox.Show(ea.Message, "Error please try again", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                read.Close();
            }
            return loginClass;
        }
    }
}
