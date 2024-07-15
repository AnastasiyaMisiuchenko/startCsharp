using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startCsharp
{
    /* 
    Задание 13: Поиск максимального элемента в каждой строке
    Напишите программу, которая создает двумерный массив 3x3 и выводит максимальный элемент в каждой строке.
    Задание 14: Транспонирование матрицы
    Напишите программу, которая создает двумерный массив 4x4 и транспонирует его.
    Задание 15: Умножение матриц
    Напишите программу, которая умножает две двумерные матрицы размером 2x2.
    Задание 16: Обратная матрица
    Напишите программу, которая находит обратную матрицу для матрицы 2x2. Если обратная матрица не существует, программа должна вывести соответствующее сообщение.
    Задание 17: Поворот матрицы на 90 градусов
    Напишите программу, которая поворачивает двумерный массив 3x3 на 90 градусов по часовой стрелке.
    Задание 18: Среднее арифметическое столбцов
    Напишите программу, которая вычисляет среднее арифметическое элементов в каждом столбце двумерного массива 3x3.
    Задание 19: Умножение матрицы на число
    Напишите программу, которая умножает каждый элемент двумерного массива 3x3 на заданное число.
    Задание 20: Нахождение минимального элемента в каждой строке
    Напишите программу, которая находит минимальный элемент в каждой строке двумерного массива 3x3.


    Задание 21: Класс для представления человека
    Создайте класс Person, который будет содержать следующие поля: имя, возраст, пол. Добавьте методы для вывода информации о человеке и увеличения возраста.

    Задание 22: Класс для представления автомобиля
    Создайте класс Car, который будет содержать поля: марка, модель, год выпуска и пробег. Добавьте методы для вывода информации об автомобиле и увеличения пробега.

    Задание 23: Класс для представления банковского счета
    Создайте класс BankAccount, который будет содержать поля: номер счета, владелец счета, баланс. Добавьте методы для вывода информации о счете, внесения и снятия денег.

    Задание 24: Класс для представления студента
    Создайте класс Student, который будет содержать поля: имя, возраст, список оценок. Добавьте методы для вывода информации о студенте, добавления новой оценки и вычисления среднего балла.

    Задание 25: Класс для представления прямоугольника
    Создайте класс Rectangle, который будет содержать поля: длина и ширина. Добавьте методы для вычисления площади и периметра прямоугольника.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            setarr();

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

        static void num()
        {/* Задание 1: Напишите программу, которая запрашивает у пользователя число и выводит сообщение, 
          является ли оно четным или нечетным.*/
            Console.Write("Введите число: ");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
        }

        static void temp()
        {/* Задание 2: Напишите программу, которая запрашивает у пользователя температуру и выводит 
          сообщение о том, жарко, холодно или нормально.*/
            Console.WriteLine("Какая сейчас температура?");
            int t = int.Parse(Console.ReadLine());  
            if (t < 5)
            {
                Console.WriteLine("Cейчас холодно.");
            }
            if (t > 5 && t < 22)
            {
                Console.WriteLine("Сейчас нормальная температура.");
            }
            if (t > 22)
            {
                Console.WriteLine("Сейчас жарко.");
            }

        }

        static void factorial()
        {/* Задание 3: Напишите программу, которая запрашивает у пользователя число и вычисляет его факториал.*/
            Console.Write("Введите число:");
            int f = int.Parse(Console.ReadLine());
            int fakt = 1;
            while (f > 1)
            {
                f = f - 1;
                fakt *= f;
            }
            Console.WriteLine(fakt);
        }

        static void umnojenie()
        {/* Задание 4: Напишите программу, которая выводит таблицу умножения от 1 до 10.*/
            int a = 1;
            for (a = 1; a < 11; a++)
            {
                Console.Write(a);
                Console.Write(" * ");
                Console.Write(1);
                Console.Write(" = ");
                Console.WriteLine(1 * a);
            }
            Console.WriteLine();
            for (a = 1; a < 11; a++)
            {
                Console.Write(a);
                Console.Write(" * ");
                Console.Write(2);
                Console.Write(" = ");
                Console.WriteLine(2 * a);
            }
            Console.WriteLine();
            for (a = 1; a < 11; a++)
            {
                Console.Write(a);
                Console.Write(" * ");
                Console.Write(3);
                Console.Write(" = ");
                Console.WriteLine(3 * a);
            }
            Console.WriteLine();
            for (a = 1; a < 11; a++)
            {
                Console.Write(a);
                Console.Write(" * ");
                Console.Write(4);
                Console.Write(" = ");
                Console.WriteLine(4 * a);
            }
            Console.WriteLine();
            for (a = 1; a < 11; a++)
            {
                Console.Write(a);
                Console.Write(" * ");
                Console.Write(5);
                Console.Write(" = ");
                Console.WriteLine(5 * a);
            }
            Console.WriteLine();
            for (a = 1; a < 11; a++)
            {
                Console.Write(a);
                Console.Write(" * ");
                Console.Write(6);
                Console.Write(" = ");
                Console.WriteLine(6 * a);
            }
            Console.WriteLine();
            for (a = 1; a < 11; a++)
            {
                Console.Write(a);
                Console.Write(" * ");
                Console.Write(7);
                Console.Write(" = ");
                Console.WriteLine(7 * a);
            }
            Console.WriteLine();
            for (a = 1; a < 11; a++)
            {
                Console.Write(a);
                Console.Write(" * ");
                Console.Write(8);
                Console.Write(" = ");
                Console.WriteLine(8 * a);
            }
            Console.WriteLine();
            for (a = 1; a < 11; a++)
            {
                Console.Write(a);
                Console.Write(" * ");
                Console.Write(9);
                Console.Write(" = ");
                Console.WriteLine(9 * a);
            }
            Console.WriteLine();
            for (a = 1; a < 11; a++)
            {
                Console.Write(a);
                Console.Write(" * ");
                Console.Write(10);
                Console.Write(" = ");
                Console.WriteLine(10 * a);
            }
        }

        static void arrsr()
        {/* Задание 5: Напишите программу, которая создает массив из 10 случайных чисел и вычисляет их среднее арифметическое.*/
            int[] arr = new int[10];
            Random rand = new Random();
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rand.Next(0,100);
                Console.WriteLine(arr[i]);
            }
            for (int i = 0; i < 10; i++)
            {
                sum += arr[i];
            }
            Console.Write("Среднее арифметическое = ");
            Console.WriteLine(sum / 10);
        }

        static void maxarr()
        {/*Задание 6: Напишите программу, которая создает массив из 10 случайных чисел и находит максимальный элемент.*/
            Random rand = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rand.Next(0, 100);
                Console.WriteLine(arr[i]);
            }
            Console.Write("Наибольшее значение в массиве равно: ");
            Console.WriteLine(arr.Max());
        }

        static void sumarr()
        {/*Задание 7: Напишите программу, которая создает двумерный массив 3x3 из случайных чисел и вычисляет сумму его элементов.*/
            Random random = new Random();
            int[,] arr = new int[3, 3];
            int sum = 0;    
            for (int i = 0; i < 3; i++)
            {
                for( int j = 0; j < 3; j++)
                {
                    arr[i, j] = random.Next(0, 50);
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.Write("Cумма всех элементов массива равна: ");
            Console.WriteLine(sum);
        }

        static void trarr() // ДОДЕЛАТЬ
        {/*Задание 8: Напишите программу, которая создает двумерный массив 3x3 из случайных чисел и транспонирует его.*/
            Random rand = new Random();
            int[,] arr = new int[3, 3];
            int a;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i,j] = rand.Next(0, 50);
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a = arr[i, j];
                    arr[i, j] = arr[j, i];
                    arr[j, i] = a;
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }

        static int sumnumber(int x, int y)
        {
            return x + y;
        }

        static void sumnum()
        {/*Задание 9: Функция для вычисления суммы двух чисел
         Напишите функцию, которая принимает два числа и возвращает их сумму.*/
            Console.WriteLine("Введите первое число: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Cумма двух чисел равна: ");
            Console.WriteLine(sumnumber(x, y));
        }

        static int maxarr0(int[] arr)
        {
            return arr.Max();
        }
        static void maxarr1()
        {/*Задание 10: Напишите функцию, которая принимает массив чисел и возвращает максимальный элемент.*/
            Random rand = new Random();
            int[] arr = new int[10];
            for (int i =0; i<10; i++)
            {
                arr[i] = rand.Next(0,25);
                Console.WriteLine(arr[i]);
            }
            Console.Write("Наибольшее значение в массиве равно: ");
            Console.WriteLine(maxarr0(arr));
        }

        static void setarr()
        {/*Задание 11: Напишите программу, которая заполняет двумерный массив размером 4x4 случайными числами и выводит его на экран.*/
            int[,] arr = new int[4, 4];
            Random rand = new Random(); 
            for (int i =0; i<4; i++)
            {
                for (int j =0; j<4; j++)
                {
                    arr[i,j] = rand.Next(0,25);
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void darr()
        {/*Задание 12: Напишите программу, которая создает двумерный массив 5x5 и вычисляет сумму элементов на главной диагонали.*/
        
        }

    }
}

