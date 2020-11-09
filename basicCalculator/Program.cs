using System;
using System.Runtime.ExceptionServices;

namespace basicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" enter your first number : ");
            int first = Int32.Parse(Console.ReadLine());
            Console.Write(" enter your second number : ");
            int second = Int32.Parse(Console.ReadLine());
            int result = first + second;
            Console.WriteLine(first + "+" + second + "=" + result);
            result = first - second;
            Console.WriteLine(first + " - " + second + " = " + result);
            result = first / second;
            Console.WriteLine(first + " / " + second + " = " + result);
            result = first * second;
            Console.WriteLine(first + " * " + second + " = " + result);


        }
    }
}
