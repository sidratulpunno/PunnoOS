﻿using System;
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
    public static class beep
    {
        public static void TryCheck()
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  OK  ");
            Console.ResetColor();
            Console.WriteLine("] PunnoOS: beep");
        }
        public static void Main()
        {
            Console.Beep();
        }
    }
}

