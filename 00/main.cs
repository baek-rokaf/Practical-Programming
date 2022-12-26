using System;

namespace Prac
{
    class Program
    {
        static void Main(string[] args)
          {
            Console.WriteLine("Please select a menu");
            Console.Writeline("1. Cheese barger");
            Console.WriteLine("2. Double cheese burger");
            Console.WriteLine("3. Veggie burger");
            Console.WriteLine("4. Cheese & mushroom burger");
            int menu = int.Parse(Console.ReadLine());
            switch(menu)
            {
              case 1:
              Console.WriteLine("You selected a cheese burger");
              Console.Writeline("Price: $3");
              break;
              case 2:
              Console.WriteLine("You selected a double cheese burger");
              Console.Writeline("Price: $4.50") :
              break;
              case 3:
              Console.WriteLine("You selected a veggie burger");
              Console.Writeline("Price: $4");
              break;
              case 4:
              Console.WriteLine("You selected a mushroom burger*);
              Console.Writeline("Price: $5");
              break;
              default:
              Console.Writeline("Please enter a correct number(1~4) "):
              break;
            }
          }
        }
      }
  }
}