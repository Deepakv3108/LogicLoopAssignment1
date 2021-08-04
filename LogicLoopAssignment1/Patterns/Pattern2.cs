using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLoopAssignment1.Patterns
{
    public class Pattern2
    {
        public void printPattern()
        {
            Console.Write("Please specify number of lines from where your triangle will degrade: ");
            int noOfLines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= noOfLines; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                if(i == noOfLines)
                {
                    for (int k = i; k > 0; k--)
                    {
                        for (int l = k; l > 0; l--)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                }
                
            }
        }
    }
}
