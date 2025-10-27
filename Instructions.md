RequestMachineIAPI

RequestMachineIAPI is a lightweight .NET library designed to retrieve essential hardware information from a machine. It's ideal for applications that need quick access to system data, such as monitoring or diagnostics tools.

Features

Retrieve RAM information in megabytes.

Access storage details for all drives.

Minimal and easy-to-use API.

Compatible with .NET 9.0+.

No external dependencies.

Installation

To install the package via NuGet, run the following command in your project directory:

dotnet add package RequestMachineIAPI

Usage

Once installed, you can use the library to access hardware information. Here's an example:

using RequestMachineIAPI;

class Program
{
    static void Main()
    {
        // Get RAM information
        Console.WriteLine($"RAM: {HardwareInfo.RequestRamInfo} MB");

        // Get storage information
        Console.WriteLine("Storage Info:");
        HardwareInfo.AdvancedHardware.RequestStorage();
    }
}


In this example:

HardwareInfo.RequestRamInfo retrieves the total RAM in megabytes.

HardwareInfo.AdvancedHardware.RequestStorage() lists the storage details for all drives.

License

This project is licensed under the MIT License.
