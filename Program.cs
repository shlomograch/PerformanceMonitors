using System;
using System.Diagnostics;
using System.Threading;

namespace ServerLoadWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            cpuCounter.NextValue();
            ramCounter.NextValue();

            Thread.Sleep(1000);

            ServerLoadModel db = new ServerLoadModel();
            ServerLoad newLoad = new ServerLoad
            {
                DnsName = Environment.MachineName,
                CpuUtilization = cpuCounter.NextValue().ToString(),
                MemoryUtilization = ramCounter.NextValue().ToString(),
                Date = DateTime.Now.ToString()
            };

            db.ServerLoads.Add(newLoad);
            db.SaveChanges();
        }
    }
}
