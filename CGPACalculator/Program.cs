using System;
using System.Collections.Generic;

namespace CGPACalculator
{
    class Program
    {
        public static object TableUI { get; private set; }

        static void Main(string[] args)
        {
            GpaUI.Start();
            _ = TableUI;
        }
    }
}
