﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++) {
                if (i % 3 == 0) {
                    Console.Write(i + " \n");
                }
            }
            Console.ReadKey();
        }
    }
}
