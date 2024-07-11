using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());
            //double pi = 3.142; //soln to avoid problems caused due to magic numbers
            double area = 3.142 * radius * radius; //using magic number
            //double area = pi * radius * radius;
            Console.WriteLine("The area of the circle is: " + area);
        }
    }
}
