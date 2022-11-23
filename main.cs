using System;

namespace LossPrecisionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1234567890;
            float num2 = num1;
            Console.WriteLine(num1 - (int)num2);
        }



    }
}
