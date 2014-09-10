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
            double totalhours;
            System.Console.Write("Enter name: "); string name = System.Console.ReadLine();
            System.Console.Write(name + "'s hourly pay is: "); string pay = System.Console.ReadLine(); newpay = Convert.ToDouble(pay);
            System.Console.Write(name + "'s hours worked: "); string hours = System.Console.ReadLine(); totalhours = Convert.ToDouble(hours);
            System.Console.WriteLine("\nThe federal widthold is: " + newpay * .15); newpay -= newpay * .15;
            System.Console.WriteLine("The state witholding is: " + newpay * .05); newpay -= newpay * .05;
            System.Console.WriteLine("\nYou have earned " + newpay * totalhours + " at " + newpay + " per hour");
        }
    }
}
