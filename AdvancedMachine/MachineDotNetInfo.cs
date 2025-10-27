namespace RequestMachineIAPI.AdvancedMachine;

using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

public class MachineDotNetInfo
{
    public static string RequestDotNetVersion()
    {
        return Environment.Version.ToString();
    }

    public static string RequestDotNetVersionF()
    {
        return RuntimeInformation.FrameworkDescription;
    }

    public static string RequestDotNetArchitecture()
    {
        return Environment.Is64BitProcess ? "x64" : "x86";
    }

    public static string RequestDotNetBaseDirectory()
    {
        return AppContext.BaseDirectory;
    }

    public static string RequestDotNetAssemblyLocation()
    {
        return typeof(object).Assembly.Location;
    }
}

public class MachineDotNetInfoVoid
{
    public static void RequestDotNetVersion()
    {
        Console.WriteLine(Environment.Version.ToString());
    }

    public static void RequestDotNetVersionF()
    {
        Console.WriteLine(RuntimeInformation.FrameworkDescription);
    }

    public static void RequestDotNetArchitecture()
    {
        Console.WriteLine(Environment.Is64BitProcess ? "x64" : "x86");
    }

    public static void RequestDotNetBaseDirectory()
    {
        Console.WriteLine(AppContext.BaseDirectory);
    }

    public static void RequestDotNetAssemblyLocation()
    {
        Console.WriteLine(typeof(object).Assembly.Location);
    }
}