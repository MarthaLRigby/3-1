﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            float f = 98.6F;
            double d = 12345.6789;
            char c = 'z';
            string s = "The quick brown fox jumped over the lazy dogs.";
            Console.WriteLine(i + " " + f + " " + d + " " + c + " " + s);
            i = 25;
            f = 100.3F;
            d = 98765.4321;
            c = 'M';
            s = "A quick movement of the enemy will jeopardise six gun boats";
            Console.WriteLine(i + " " + f + " " + d + " " + c + " " + s);
        }
    }
}
