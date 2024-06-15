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
    public static class sysinfo
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] Punno app: sysinfo");
        }
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PunnoOS");
            



            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Beep();
            Console.WriteLine("Operating System Version: 0.1.7 Open Source");
            Console.WriteLine("All Installation of RAM: " + CPU.GetAmountOfRAM() + "MB");
            Console.WriteLine("All available of Memory: " + CPU.GetEndOfKernel() + 1024 / 1048576 + "KB");
            Console.WriteLine("CPU: " + CPU.GetCPUBrandString());


            Console.Beep();
            Console.ResetColor();
        }
    }
}

