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
    public static class help
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] PunnoOS: help");
        }
        public static void Main()
        {
            Console.WriteLine("echo -- displaying lines of text by echo (your message)\r\nbeep -- playing beep sound\r\nplaybeep -- playbeep sound");
            Console.WriteLine("sysinfo -- show nodemoon icon, cpu info, ram\r\nkernelinfo -- show name, version, based of nodekernel.\r\nhardwareinfo -- show hardware info are possible we can do.");
            Console.WriteLine("date -- show date and time\r\npowercontrol -- reboot or shutdown device eg. powercontrol reboot, powercontrol shutdown");
            Console.WriteLine("diskmg -- check disk info");
            Console.WriteLine("cd -- cd directory path eg cd baka\r\nls -- list of file & dir eg.");
            Console.WriteLine("mkdir -- create folder");
            Console.WriteLine("remove -- remove file"); 
            Console.WriteLine("touch -- create file");
            Console.WriteLine("happy coding");

        }
    }
}

