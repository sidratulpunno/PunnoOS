using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.HAL;
using System.Threading;
using Cosmos.Core;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using PunnoOS.apps;
using PunnoOS.services;
using System.IO;
using Cosmos.System.Network.IPv4.UDP.DHCP;
using Cosmos.System.Network.IPv4;
using Cosmos.System.Network.IPv4.TCP;
using Cosmos.System.Network.Config;
using System.Net.NetworkInformation;
using Cosmos.System.Graphics;

namespace PunnoOS
{
    public class Kernel : Sys.Kernel
    {
        public string tryit;
        public static string historypath = @"0:\";
        protected override void BeforeRun()
        {
            Console.Write("Welcome to ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PunnoOS!");
            Console.ResetColor();
            Console.WriteLine("Now Wait For PunnoKernel.");
            Cosmos.HAL.Global.PIT.Wait(3000);
            Console.ResetColor();
            Punno.TryBoot();
            appmanager.TrySee();
            echoapp.TryCheck();
            powercontrol.TryCheck();
            sysinfo.TryCheck();
            date.TryCheck();
            Calculator.TryCheck(); // Check if the Calculator is available
            Cosmos.HAL.Global.PIT.Wait(2000);
            diskrun.autorun();
            Cosmos.HAL.Global.PIT.Wait(1000);
        }

        protected override void Run()
        {
            Punno.Welcome();
            Console.WriteLine("Mounting a PunnoOS");
        antidownwithoutreason:
            Punno.Main(historypath);
            goto antidownwithoutreason;
        }
        public static void PathCD(string historypath)
        {
        antidownwithoutreason:
            Punno.Main(historypath);
            goto antidownwithoutreason;
        }
        public static void Resetpath()
        {
            string historypath = @"0:\";
        antidownwithoutreason:
            Punno.Main(historypath);
            goto antidownwithoutreason;
        }
    }
}