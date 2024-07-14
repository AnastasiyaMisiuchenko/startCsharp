using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator();

            Console.ReadKey();
        }

        static void sum()
        {
            Console.WriteLine("Введите первое число: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int y = Int32.Parse(Console.ReadLine());
            int sum = x + y;
            Console.WriteLine(sum);
        }

        static void calculator()
        {
            int select, a, b;
            do
            {
                Console.WriteLine("Хотите воспользоваться калькулятором (1) или выйти(2)?");
                select = Int32.Parse(Console.ReadLine());
                if (select == 1)
                {
                    Console.WriteLine("Какое действие необходимо выполнить?");
                    Console.WriteLine("1 - Найти сумму");
                    Console.WriteLine("2 - Найти произдение");
                    Console.WriteLine("3 - Найти разницу");
                    Console.WriteLine("4 - Найти рaзность");
                    int set = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите первое число:");
                    a = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    b = Int32.Parse(Console.ReadLine());
                    
                    if (set == 1)
                    {
                        Console.Write("Сумма равна: ");
                        Console.WriteLine(a + b);
                        Console.WriteLine();
                    }
                    if (set == 2)
                    {
                        Console.Write("Произведение равно: ");
                        Console.WriteLine(a * b);
                        Console.WriteLine();
                    }
                    if (set == 3)
                    {
                        Console.Write("Разница равна: ");
                        Console.WriteLine(a - b);
                        Console.WriteLine();
                    }
                    if (set == 4)
                    {
                        Console.Write("Разность равна: ");
                        Console.WriteLine(a / b);
                        Console.WriteLine();
                    }
                }

            } while (select != 2);
        }


    }
}
