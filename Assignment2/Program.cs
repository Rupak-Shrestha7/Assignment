using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a whole number: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
                {
                    Console.Write("The number is positive ");
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("and even");
                    }
                    else
                    {
                        Console.WriteLine("and odd");
                    }
                }
                else if (number < 0)
                {
                    Console.Write("The number is negative ");
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("and even");
                    }
                    else
                    {
                        Console.WriteLine("and odd");
                    }
                }
                else
                {
                    Console.WriteLine("The number is zero (and it is even)");
                }
            }
        }
}
