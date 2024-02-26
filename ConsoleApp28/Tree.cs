using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Tree
    {
       public  int CalculateTreeLength(int periods)
        {
            int length = 1;
            for (int period = 0; period <= periods; period++)
            {
                length *= 2;
                length += period;
            }
            return length;

            int treeLength = CalculateTreeLength(periods);
            Console.WriteLine(treeLength);

        }


    }
}
