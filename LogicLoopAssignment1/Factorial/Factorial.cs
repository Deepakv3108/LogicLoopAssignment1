using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLoopAssignment1.Factorial
{
    public class Factorial
    {
        public void printFactorial()
        {
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int fact = 1;

            for (int i = number; i > 0; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
