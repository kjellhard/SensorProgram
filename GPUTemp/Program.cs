using System;
using OpenHardwareMonitor.Hardware;

class Program
{
    public static void Main()
    {
        Server server = new Server();
        server.StartServer();
    }
}
