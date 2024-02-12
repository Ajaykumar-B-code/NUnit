using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drivingAgeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dAgeChecker = new driveAgeChecker();

            Console.WriteLine("Enter the Age: ");
            var age = Convert.ToInt32(Console.ReadLine());

            var result = dAgeChecker.AgeChecker(age);

            Console.WriteLine($"Person is {result} for driving");
            Console.ReadLine();
        }
    }
}
