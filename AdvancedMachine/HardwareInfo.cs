namespace RequestMachineIAPI.AdvancedMachine;

using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Diagnostics;
using System.Reflection;

public class HardwareInfo
{
    public static string RequestRamInfo = (GC.GetGCMemoryInfo().TotalAvailableMemoryBytes / (1024 * 1024)) + " MB";

    public class AdvancedHardware
    {
        public static string RequestStorage()
        {
            string result = "";
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var d in drives)
            {
                if (d.IsReady)
                    result += $"{d.Name} - Free: {d.TotalFreeSpace / (1024 * 1024)} MB{Environment.NewLine}";
            }

            return result;
        }
    }
}

public class HardwareInfoVoid
{
    public static void RequestRamInfo()
    {
        Console.WriteLine(GC.GetGCMemoryInfo().TotalAvailableMemoryBytes / (1024 * 1024));
    }

    public class AdvancedHardware
    {
        public static void RequestStorage()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var d in drives)
            {
                if (d.IsReady)
                    Console.WriteLine(d.TotalFreeSpace / (1024 * 1024));
            }
        }
    }
}