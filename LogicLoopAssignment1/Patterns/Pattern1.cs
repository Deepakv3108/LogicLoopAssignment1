using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLoopAssignment1.Patterns
{
    public class Pattern1
    {
        public void printPattern()
        {
            Console.Write("Please specify number of lines: ");
            int noOfLines = int.Parse(Console.ReadLine());

            for(int i=1; i <= noOfLines; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
