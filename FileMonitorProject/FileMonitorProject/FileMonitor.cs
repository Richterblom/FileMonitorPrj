using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileMonitorProject
{
    public partial class FileMonitor : Form
    {
        //create filesystemwatcher
        FileSystemWatcher fileWatcher = new FileSystemWatcher();
        //create instance
        List<MonitoringData> monitorData = new List<MonitoringData>();
        //allows you to hover over a textbox and display info about said text box
        ToolTip toolTip = new ToolTip();

        public FileMonitor()
        {
            InitializeComponent();
            //events that watch if a file is created ,deleted or renamed
            fileWatcher.Renamed += new RenamedEventHandler(ChangeMonitoredRecords);
            fileWatcher.Created += new FileSystemEventHandler(ChangeMonitoredRecords);
            fileWatcher.Deleted += new FileSystemEventHandler(ChangeMonitoredRecords);
            fileWatcher.Changed += new FileSystemEventHandler(ChangeMonitoredRecords);
            dgvFileChangeRecords.DataSource = monitorData;
            toolTip.SetToolTip(this.txtSearchBox, "Search For the Type of change that has occurred.");
        }

        
        //create own method which calls when a file is created, changed, or deleted.
        public void ChangeMonitoredRecords(object source, FileSystemEventArgs e)
        {
            //layout of how each file wll be displayed and say if it was created ,changed and deleted
            monitorData.Add(new MonitoringData(e.FullPath, e.ChangeType.ToString(), DateTime.Now));
         //my notifications
            notify.Visible = true;
            notify.BalloonTipTitle = "File Modification has occurred";
            notify.BalloonTipText ="change happened at " + e.FullPath + " type change is " + e.ChangeType.ToString();
            notify.ShowBalloonTip(1000);
            //have to call method else the information has no where to be displayed
            DisplayDgv();
        }

       //browser 
        string path = "";
        public void BrowseFiles()
        {
            //asks user to get folder
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //gets or sets path by the user
                    path = fbd.SelectedPath;
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                }
            }
        }
        //btn To activate looking for Folder
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //calls for BrowseFiles
            BrowseFiles();
        }

        delegate void DisplayOnDGV();
       //invokation delegate
        public void DisplayDgv()
        {
            if (this.dgvFileChangeRecords.InvokeRequired)
            {
                DisplayOnDGV view = new DisplayOnDGV(DisplayDgv);
                
                this.Invoke(view);
            }
            else
            {
                dgvFileChangeRecords.DataSource = null;
                dgvFileChangeRecords.DataSource = monitorData;
            }
        }

        private void btnStartMonitor_Click(object sender, EventArgs e)
        {
            try
            {
                fileWatcher.Path = path;
                if (cbIncludeSubIdercories.Checked)
                {
                    //checks to see if subdirectorry is chosen
                    fileWatcher.IncludeSubdirectories = true;
                    MessageBox.Show("File monitor has begun");
                }
                //raise events in control
                fileWatcher.EnableRaisingEvents = true;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error does not run");
                BrowseFiles();
            }
        }

        private void btnEndMonitor_Click(object sender, EventArgs e)
        {
            fileWatcher.EnableRaisingEvents = false;
            MessageBox.Show("end");
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            List<MonitoringData> filteringList = new List<MonitoringData>();

            if (txtSearchBox.Text != null || txtSearchBox.Text != "")
            {
                foreach (MonitoringData dataItem in monitorData)
                {
                    if (dataItem.ChangeOccurred.ToLower().Contains(txtSearchBox.Text))
                    {
                        filteringList.Add(dataItem);
                    }
                }
                dgvFileChangeRecords.DataSource = filteringList;
            }
            else
            {
                DisplayDgv();
            }
        }
        DateTime startDate;
        DateTime endDate;
        public void CheckTime(object sender , EventArgs e)
        {  
            if (DateTime.Now >= startDate)
            {
                try
                {
                    if (cbIncludeSubIdercories.Checked)
                    {
                        //checks to see if subdirectorry is chosen
                        fileWatcher.IncludeSubdirectories = true;
                        MessageBox.Show("File monitor has begun");
                    }
                    //raise events in control
                    fileWatcher.EnableRaisingEvents = true;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Error does not run");
                    BrowseFiles();
                }
            }
            if (DateTime.Now>=endDate)
            {
                fileWatcher.EnableRaisingEvents = false;
                MessageBox.Show("end");
            }
        }

        private void btnTimeMonitoring_Click(object sender, EventArgs e)
        {
           startDate = dtpStartDate.Value;
           endDate = dtpEndDate.Value;
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                //return value  of dialog
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //gets or sets path by the user
                    path = fbd.SelectedPath;
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                }
            }
            fileWatcher.Path = path;
            tTimer.Start();
            tTimer.Interval = 1000;
            tTimer.Tick += CheckTime;
        }

        private void FileMonitor_Load(object sender, EventArgs e)
        {
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "yyyy-MM-dd  hh:mm:ss";
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = "yyyy-MM-dd  hh:mm:ss";
        }
    }
}

