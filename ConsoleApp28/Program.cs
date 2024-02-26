using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)

        {
            CalculateTreeLenght();

        }
        public static void CalculateTreeLenght()
        {
            int length = -1;
            Console.WriteLine("input periods");
            int periodinput= Convert.ToInt32(Console.ReadLine());
            for (int period = 0; period <= periodinput; period++)
            {
                length += 1;
                length *= 2; 
            }

            Console.WriteLine($"tree's length is {length}");
        }
    }
}
