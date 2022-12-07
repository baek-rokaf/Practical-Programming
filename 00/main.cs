using System;

namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string numStr1 = Console.ReadLine();
            int num1 = int.Parse(numStr1);
            Console.Write("Enter the second number: ");
            string numStr2 = Console.ReadLine();
            int num2 = int.Parse(numStr2);
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
    }
}
