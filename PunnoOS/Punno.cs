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
using PunnoOS.apps;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using System.IO;


namespace PunnoOS
{
    public static class Punno
        {
        
        public static void TryBoot()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] PunnoOS Global");
        }
        public static void Main(string historypath)
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("PunnoOS");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("localhost");
            Console.ResetColor();
            Console.Write("(" + historypath + ")" + " > ");
            var input = Console.ReadLine();
            appmanager.Main(input, historypath);
        }
        public static void Welcome()
        {
            Console.WriteLine("Welcome to PunnoOS! (PunnoKernel 1.2.0 Stable x86_64)");
            
        }
    }
	}

