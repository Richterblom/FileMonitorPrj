using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileMonitorProject
{
    class MonitoringData
    {
        private string directory;

        public string Directory
        {
            get { return directory; }
            set { directory = value; }
        }

        private string changeOccurred;

        public string ChangeOccurred
        {
            get { return changeOccurred; }
            set { changeOccurred = value; }
        }

        private DateTime timeOfChange;

        public DateTime TimeOfChange
        {
            get { return timeOfChange; }
            set { timeOfChange = value; }
        }

        public MonitoringData(string directory, string changeOccurred, DateTime timeOfChange)
        {
            this.directory = directory;
            this.changeOccurred = changeOccurred;
            this.timeOfChange = timeOfChange;
        }
    }
}
