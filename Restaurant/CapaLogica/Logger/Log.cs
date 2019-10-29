﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Logger
{
    public class Log
    {
        public static void Write(string message,string type)
        {
            WriteDB(type+"  --->"+message, true);
        }

        public static void Write(string message)
        {
            WriteDB(message, true);
        }

        // Util por si solo queremos utilizar el Log para debug
        public static void WriteDB(string message, bool show)
        {
            if (show)
                Console.WriteLine(message);
        }
    }
}
