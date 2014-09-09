using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 42;
            int lenght = 25;
            double cost = 1.75;
            System.Console.WriteLine("The floor space is " + width*lenght + " square feet, which is " + (width*lenght)/9 + " square yards, thus it is $"+((width*lenght)/9)*cost);
        }
    }
}
