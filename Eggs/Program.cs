using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs = 127;
            System.Console.WriteLine("You have collected " + eggs + " eggs that is " + eggs / 12 + " dozen and " + eggs % 12 + " eggs");

        }
    }
}
