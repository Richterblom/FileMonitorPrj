using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileMonitorProject
{
    class CustomMessage : Exception
    {
        public CustomMessage(string message) : base(message)
        {

        }
    }
}
