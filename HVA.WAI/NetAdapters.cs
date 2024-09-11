// http:\\msdn.microsoft.com\en-us\library\aa394216 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;


namespace HVA.WAI
{
    public sealed class NetAdapters
    {
        ManagementObjectSearcher searchProcedure;

        public NetAdapters()
        {
            SelectQuery wmiQuery = new SelectQuery("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionId != NULL");
            searchProcedure = new ManagementObjectSearcher(wmiQuery);
        }

        public enum NetworkAdapterInfo
        {
            AdapterType,
            AdapterTypeID,
            AutoSense,
            Availability,
            Caption,
            ConfigManagerErrorCode,
            ConfigManagerUserConfig,
            CreationClassName,
            Description,
            DeviceID,
            ErrorCleared,
            ErrorDescription,
            GUID,
            Index,
            InstallDate,
            Installed,
            InterfaceIndex,
            LastErrorCode,
            MACAddress,
            Manufacturer,
            MaxNumberControlled,
            MaxSpeed,
            Name,
            NetConnectionID,
            NetConnectionStatus,
            NetEnabled,
            NetworkAddresses,//string   NetworkAddresses[];
            PermanentAddress,
            PhysicalAdapter,
            PNPDeviceID,
            PowerManagementCapabilities,//uint16   PowerManagementCapabilities[];
            PowerManagementSupported,
            ProductName,
            ServiceName,
            Speed,
            Status,
            StatusInfo,
            SystemCreationClassName,
            SystemName,
            TimeOfLastReset,
        }
        public string NetConnectionStatus()
        {
            int? ststusCode = null;
            string Condition = string.Empty;
            switch (ststusCode)
            {
                case 0: Condition = "Disconnected"; break;
                case 1: Condition = "Connecting"; break;
                case 2: Condition = "Connected"; break;
                case 3: Condition = "Disconnecting"; break;
                case 4: Condition = "Hardware not present"; break;
                case 5: Condition = "Hardware disabled"; break;
                case 6: Condition = "Hardware malfunction"; break;
                case 7: Condition = "Media disconnected"; break;
                case 8: Condition = "Authenticating"; break;
                case 9: Condition = "Authentication succeeded"; break;
                case 10: Condition = "Authentication failed"; break;
                case 11: Condition = "Invalid address"; break;
                case 12: Condition = "Credentials required"; break;
                default:
                    Condition = "UnKnow";
                    break;
            }
            return Condition;
        }
        public string ConfigManagerErrorCode()
        {
            int? errorCode = null;
            string errorDiscript = string.Empty;
            switch (errorCode)
            {

                case 0: errorDiscript = "Device is working properly."; break;
                case 1: errorDiscript = "Device is not configured correctly."; break;
                case 2: errorDiscript = "Windows cannot load the driver for this device."; break;
                case 3: errorDiscript = "Driver for this device might be corrupted, or the system may be low on memory or other resources."; break;
                case 4: errorDiscript = "Device is not working properly. One of its drivers or the registry might be corrupted."; break;
                case 5: errorDiscript = "Driver for the device requires a resource that Windows cannot manage."; break;
                case 6: errorDiscript = "Boot configuration for the device conflicts with other devices."; break;
                case 7: errorDiscript = "Cannot filter."; break;
                case 8: errorDiscript = "Driver loader for the device is missing."; break;
                case 9: errorDiscript = "Device is not working properly. The controlling firmware is incorrectly reporting the resources for the device."; break;
                case 10: errorDiscript = "Device cannot start."; break;
                case 11: errorDiscript = "Device failed."; break;
                case 12: errorDiscript = "Device cannot find enough free resources to use."; break;
                case 13: errorDiscript = "Windows cannot verify the device's resources."; break;
                case 14: errorDiscript = "Device cannot work properly until the computer is restarted."; break;
                case 15: errorDiscript = "Device is not working properly due to a possible re-enumeration problem."; break;
                case 16: errorDiscript = "Windows cannot identify all of the resources that the device uses."; break;
                case 17: errorDiscript = "Device is requesting an unknown resource type."; break;
                case 18: errorDiscript = "Device drivers must be reinstalled."; break;
                case 19: errorDiscript = "Failure using the VxD loader."; break;
                case 20: errorDiscript = "Registry might be corrupted."; break;
                case 21: errorDiscript = "System failure. If changing the device driver is ineffective, see the hardware documentation. Windows is removing the device."; break;
                case 22: errorDiscript = "Device is disabled."; break;
                case 23: errorDiscript = "System failure. If changing the device driver is ineffective, see the hardware documentation."; break;
                case 24: errorDiscript = "Device is not present, not working properly, or does not have all of its drivers installed."; break;
                case 25: errorDiscript = "Windows is still setting up the device."; break;
                case 26: errorDiscript = "Windows is still setting up the device."; break;
                case 27: errorDiscript = "Device does not have valid log configuration."; break;
                case 28: errorDiscript = "Device drivers are not installed."; break;
                case 29: errorDiscript = "Device is disabled. The device firmware did not provide the required resources."; break;
                case 30: errorDiscript = "Device is using an IRQ resource that another device is using."; break;
                case 31: errorDiscript = "Device is not working properly. Windows cannot load the required device drivers."; break;
                case 32: errorDiscript = ""; break;
                default:
                    errorDiscript = "UnKnow";
                    break;
            }
            return errorDiscript;
        }
        public string AdapterTypeID()
        {
            int? typeId = null;
            string typeName = string.Empty;
            switch (typeId)
            {
                case 0:
                    typeName = "Ethernet 802.3";
                    break;

                case 1:
                    typeName = "Token Ring 802.5";
                    break;

                case 2:
                    typeName = "Fiber Distributed Data Interface (FDDI)";
                    break;

                case 3:
                    typeName = "Wide Area Network (WAN)";
                    break;

                case 4:
                    typeName = "LocalTalk";
                    break;

                case 5:
                    typeName = "Ethernet using DIX header format";
                    break;

                case 6:
                    typeName = "ARCNET";
                    break;

                case 7:
                    typeName = "ARCNET (878.2)";
                    break;

                case 8:
                    typeName = "ATM";
                    break;

                case 9:
                    typeName = "Wireless";
                    break;

                case 10:
                    typeName = "Infrared Wireless";
                    break;

                case 11:
                    typeName = "Bpc"; break;

                case 12:
                    typeName = "CoWan";
                    break;

                case 13:
                    typeName = "1394";
                    break;
                default:
                    typeName = "UnKnow";
                    break;
            }
            return typeName;
        }

        public bool DisableAllAdapter()
        {
            try
            {
                foreach (ManagementObject item in searchProcedure.Get())
                {

                    item.InvokeMethod("Disable", null);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
