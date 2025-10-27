namespace RequestMachineIAPI.RequestIP;
using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Diagnostics;
using System.Reflection;
using System.Net.Sockets;

public class MachineIP
{
    public static string RequestIP()
    {
        return Dns.GetHostAddresses(Dns.GetHostName())
            .First(a => a.AddressFamily == AddressFamily.InterNetwork)
            .ToString();
    }
}

public class MachineIPVoid
{
    public static void RequestIP()
    {
        Console.WriteLine(Dns.GetHostAddresses(Dns.GetHostName()).First(a => a.AddressFamily == AddressFamily.InterNetwork).ToString());
    }
}