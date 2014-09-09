using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            double newpay;
            double federal;
            string pay = System.Console.ReadLine(); newpay = Convert.ToDouble(pay);
            System.Console.WriteLine("Enter name: "); string name = System.Console.ReadLine();
            System.Console.WriteLine(name + "'s hourly pay is: "); 
            System.Console.WriteLine("The federal widthold is: "+newpay*.15);
            System.Console.WriteLine("The state witholding is: " + newpay * .05);

        }
    }
}
