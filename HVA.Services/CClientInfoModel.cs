using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Net;
using System.Net.NetworkInformation;

namespace HVA.Services
{
    public class CClientInfoModel
    {
        public string CPUID { get; set; }


        public string CPUModel { get; set; }

        /// <summary>
        /// it was List<PhysicalAddress> MacAddresses { get; set; } in string place bute it mades error in webservice
        /// </summary>

        public List<string> MacAddresses { get; set; }


        public string OS { get; set; }


        public string ComputerName { get; set; }


        public string AccountName { get; set; }


        public IPAddress[] Ip { get; set; }


        public DateTime InstalledDate { get; set; }
        //end of table field

    }
}
