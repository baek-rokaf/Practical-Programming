using System;

namespace Week03
{
    class Program
    {
        static void Main(string[] args)
        {
            // double num1 = 10.9;
            // double num2 = 52.16;
            // Console.WriteLine("일반 덧셈 결과: " + (num1 + num2));

            // int result = (int)num1 + (int)num2;
            // Console.WriteLine("명시적 형변환 덧셈 결과: " + result);
            // //일반 덧셈 결과: 63.059999999999995
            // // 명시적 형변환 덧셈 결과: 62
            int num1 = 10;
            int num2 = 30;
            int result1 = num1 / num2; // 0
            double result2 = num1 / num2; // 0
            double result3 = (double)num1 / num2; // 0.333333333
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }



    }
}
