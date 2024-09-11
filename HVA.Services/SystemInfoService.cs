using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HVA.WAI;

namespace HVA.Services
{
    public class SystemInfoService
    {
        APIFuncs winApi;
        CClientInfoModel clientInfo;
        public SystemInfoService()
        {
            GetSystemInfo();
        }
        public CClientInfoModel SystemInfo { get; private set; }

        private CClientInfoModel GetSystemInfo()
        {
            try
            {
                winApi = new APIFuncs();
                clientInfo = new CClientInfoModel();
                clientInfo.AccountName = winApi.AccountName;
                clientInfo.ComputerName = winApi.ComputerName;
                clientInfo.InstalledDate = DateTime.Now;
                clientInfo.Ip = winApi.Ip;
                clientInfo.OS = winApi.OperatingSystem;
                clientInfo.CPUModel = winApi.CPUName;
                this.SystemInfo = clientInfo;
            }
            catch (Exception err)
            {
               
            }
            return clientInfo;
        }

        public  List<string> GetValumesInfo()
        {
            return winApi.GetValumesInfo(); 
        }
    }
}