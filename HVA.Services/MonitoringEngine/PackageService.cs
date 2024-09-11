using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Diagnostics;
using HVA.WAI;

namespace HVA.Services.MonitoringEngine
{
    public class PackageService
    {
        private DateTime appFocusTime;
        private TimeSpan applFocusInterval;
        private CClientPacketModel cPacket;
        private CClientPacketModel prevcPacket;
        public Hashtable appHash;
        private APIFuncs winApi;
        private List<CClientPacketModel> clientPacketList;

        public PackageService()
        {
            clientPacketList = new List<CClientPacketModel>();
            prevcPacket = new CClientPacketModel();
            appHash = new Hashtable();
            winApi = new APIFuncs();
           
        }

        public static int[] CalculateTime(double milisec)
        {
            int[] tmpStrArray = new int[3];

            int h, m, s = 0;
            int value = Convert.ToInt32(milisec);


            h = value / 3600;
            int tmp = m = value % 3600;
            m = m / 60;
            s = tmp % 60;

            tmpStrArray[0] = h;
            tmpStrArray[1] = m;
            tmpStrArray[2] = s;

            return tmpStrArray;
        }
        public void StartMonitoring()
        {
            lock (this)
            {
                bool isNewAppl = false;
                cPacket = new CClientPacketModel();
                IntPtr hwnd = APIFuncs.getforegroundWindow();
                Int32 pid = APIFuncs.GetWindowProcessID(hwnd);
                Process p = Process.GetProcessById(pid);
                cPacket.AppID = pid;
                if (pid == 0) return;
                cPacket.AppName = p.ProcessName;
                cPacket.AppTitle = APIFuncs.ActiveApplTitle().Trim().Replace("\0", "");
                cPacket.CaptureDate = DateTime.Now;

                //check for appId if not exist in list add it
                if (!appHash.Contains(cPacket.AppID))
                {
                    clientPacketList = new List<CClientPacketModel>();
                    clientPacketList.Add(cPacket);
                    appHash.Add(cPacket.AppID, clientPacketList);
                    cPacket.WorkTime = 0;
                    isNewAppl = true;
                }
                else
                {
                    //check inner packet lists by title if title changed but hase the same appId add it to list
                    List<CClientPacketModel> tmpClientPacketList = new List<CClientPacketModel>((List<CClientPacketModel>)appHash[cPacket.AppID]);
                    bool contains = false;

                    foreach (CClientPacketModel clientPacket in tmpClientPacketList)
                    {
                        if (clientPacket.AppTitle.Equals(cPacket.AppTitle))
                            contains = true;
                    }


                    if (!contains)//if title is new add it
                    {
                        tmpClientPacketList.Add(cPacket);
                        appHash.Remove(cPacket.AppID);
                        appHash.Add(cPacket.AppID, tmpClientPacketList);
                    }
                    else
                    {
                        //update work time if title exist
                        applFocusInterval = DateTime.Now.Subtract(appFocusTime);
                        foreach (CClientPacketModel clientPacket in tmpClientPacketList)
                        {
                            if (clientPacket.AppTitle == prevcPacket.AppTitle)
                            {
                                double prevseconds = clientPacket.WorkTime;
                                tmpClientPacketList.Remove(clientPacket);
                                prevcPacket.WorkTime = (applFocusInterval.TotalSeconds + prevseconds);
                                tmpClientPacketList.Add(prevcPacket);
                                appHash.Remove(cPacket.AppID);
                                appHash.Add(cPacket.AppID, tmpClientPacketList);
                                break;
                            }
                        }
                        prevcPacket = cPacket;
                        appFocusTime = DateTime.Now;
                    }
                }

                if (isNewAppl)
                    appFocusTime = DateTime.Now;
            }
        }
   
    }
}