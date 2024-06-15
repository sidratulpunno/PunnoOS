using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Drawing;
using Cosmos.Core.IOGroup;
using System.Threading;
using Cosmos.HAL;
using Cosmos.Core;
using Cosmos.Common;
using System.Net;
using Cosmos.System.Network;


namespace PunnoOS.apps
{
    public static class hardwareinfo
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] PunnoOS: kernelinfo");
        }
        public static void Main()
        {
            Console.WriteLine("Operating System: PunnoOS");
            Console.WriteLine("Kernel: Punno kerenel");
            Console.WriteLine("CPU: " + CPU.GetCPUBrandString());
            Console.WriteLine("RAM: " + CPU.GetAmountOfRAM() + "MB");
            Console.WriteLine("CPU Vender: " + CPU.GetCPUVendorName());
            try
            {
                Console.WriteLine("CPU Uptime: " + CPU.GetCPUUptime());
            }
            catch (Exception e)
            {
                Console.WriteLine("CPU Uptime: " + e.ToString());
            }
            Console.WriteLine("CPU Speed: " + CPU.GetCPUCycleSpeed());
        }
    }
}

