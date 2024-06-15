﻿

using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.Drawing;
using Cosmos.Core.IOGroup;
using System.Threading;
using Cosmos.HAL;
using Cosmos.Core;
using Cosmos.Common;
using System.Net;
using Cosmos.System.Network;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using System.IO;
using Cosmos.System.Graphics;

namespace PunnoOS.services
{
    public static class vgamoon
    {
        public static void runit()
        {
           
            try
            {

                

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("  OK  ");
                Console.ResetColor();
                Console.WriteLine("] PunnoOS: network services (netrun)");
            }
            catch (Exception e)
            {
                Console.WriteLine("INFO: netrun error: " + (e.ToString()));
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("FAILED");
                Console.ResetColor();
                Console.WriteLine("] PunnoOS: network services (netrun)");
            }
        }
    }
}

