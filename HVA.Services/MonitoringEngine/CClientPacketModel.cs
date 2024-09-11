using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace HVA.Services.MonitoringEngine
{
    public class CClientPacketModel
    {
        public DateTime CaptureDate { get; set; }
        public int AppID { get; set; }
        public string AppName { get; set; }
        public string AppTitle { get; set; }
        public double WorkTime { get; set; }
    }
}
