using LogicLoopAssignment1.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLoopAssignment1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("1. Hypotenuse Triangle Pattern");
                Console.WriteLine("2. Horizontal Triangle Pattern");
                Console.WriteLine("3. Factorial");
                Console.WriteLine("4. ChessBoard");
                Console.Write("Please select an option to execute: ");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Pattern1 p1 = new Pattern1();
                        p1.printPattern();
                        break;
                    case 2:
                        Pattern2 p2 = new Pattern2();
                        p2.printPattern();
                        break;
                    case 3:
                       Factorial.Factorial factorial = new Factorial.Factorial();
                        factorial.printFactorial();
                        break;
                    case 4:
                        ChessBoard.ChessBoard cb = new ChessBoard.ChessBoard();
                        cb.generateChessBoard();
                        break;
                    default:
                        Console.WriteLine("Wrong option selected");
                        break;
                }
                do
                {
                    Console.Write("Do You Wish to Proceed (y/n) ? ");
                    input = Console.ReadLine();
                }
                while (input.ToLower() != "y" && input.ToLower() != "n");
            }
            while (input.ToLower() == "y");
        }
    }
}
