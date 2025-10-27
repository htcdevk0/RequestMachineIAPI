namespace RequestMachineIAPI.AdvancedUser;

using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Diagnostics;
using System.Reflection;

public class UserInfo
{
    public static int RequestSystemUptime = Environment.TickCount;

    public static bool IsAdmin =
        new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
}