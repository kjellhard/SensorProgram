using System;
using OpenHardwareMonitor.Hardware;

class Temperature
{
    private static int temp = 0;

    public int GetTemp()
    {
        Computer computer = new Computer() { GPUEnabled = true };
        computer.Open();
        foreach (var h in computer.Hardware)
        {
            if (h.HardwareType == HardwareType.GpuNvidia)
            {
                h.Update();
                foreach (var s in h.Sensors)
                {
                    if (s.SensorType == SensorType.Temperature)
                    {
                        Console.WriteLine(s.Name + ": " + s.Value.GetValueOrDefault());
                        temp = (int)s.Value.GetValueOrDefault();
                    }

                }
            }
        }
        return temp;
    }
    
}