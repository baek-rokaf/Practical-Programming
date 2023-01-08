using System;


namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("User count: ");
          int length = int.Parse(Console.ReadLine());
          int[] ages = new int[length];
          float[] heights = new float[length];
          
          
          int totalAges = 0;
          float totalHeights = 0.0f;
          int count = 0;

          while(count < length)
          {
            Console.Write($"Enter user{count}'s age: ");
            ages[count] = int.Parse(Console.ReadLine());
            totalAges += ages[count];
            
            Console.Write($"Enter user{count}'s height: ");
            heights[count] = int.Parse(Console.ReadLine());
            totalHeights += heights[count];

            ++count;
          }
          

          Console.WriteLine("Print result----------");
          for (int i = 0; i < length; ++i)
          {
            Console.WriteLine($"User{i}: Age({ages[i]}), Height({heights[i]}cm)\n");
            
          }
          Console.WriteLine($"Total ages: {totalAges}");
          Console.WriteLine($"Total heights: {totalHeights}");
        }
   }
}
