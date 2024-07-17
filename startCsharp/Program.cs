using System;
using System.Linq;

namespace startCsharp
{
    /* 
    

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
            person();

            Console.ReadKey();
        }

        static void person()
        {
            Person Nastya = new Person("Настя", 23, "Женский");
            Nastya.printinfo();
            Nastya.uage();
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
                arr[i] = rand.Next(0, 100);
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
                for (int j = 0; j < 3; j++)
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

        static void trarr()
        {/*Задание 8: Напишите программу, которая создает двумерный массив 3x3 из случайных чисел и транспонирует его.*/
            Random rand = new Random();
            int[,] arr = new int[3, 3];
            int a;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = rand.Next(0, 50);
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            {
                for (int i = 0; i < 3; i++)
                    for (int j = i + 1; j < 3; j++)
                    {
                        a = arr[i, j];
                        arr[i, j] = arr[j, i];
                        arr[j, i] = a;
                    }
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
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
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rand.Next(0, 25);
                Console.WriteLine(arr[i]);
            }
            Console.Write("Наибольшее значение в массиве равно: ");
            Console.WriteLine(maxarr0(arr));
        }

        static void setarr()
        {/*Задание 11: Напишите программу, которая заполняет двумерный массив размером 4x4 случайными числами и выводит его на экран.*/
            int[,] arr = new int[4, 4];
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = rand.Next(0, 25);
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void darr()
        {/*Задание 12: Напишите программу, которая создает двумерный массив 5x5 и вычисляет сумму элементов на главной диагонали.*/
            Random rand = new Random();
            int[,] arr = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(0, 5);
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == i)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.Write("Сумма элементов по диагонали равна: ");
            Console.WriteLine(sum);
        }

        static void maxinline()
        {/*Задание 13: Напишите программу, которая создает двумерный массив 3x3 и выводит максимальный элемент в каждой строке.*/
            Random rand = new Random();
            int[,] arr = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = rand.Next(0, 5);
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[] arr1 = new int[3];
            for (int j = 0; j < 3; j++)
            {
                arr1[j] = arr[0, j];
            }
            Console.Write("Наибольшее значение в первой строке массива равно: ");
            Console.WriteLine(arr1.Max());
            int[] arr2 = new int[3];
            for (int i = 0; i < 3; i++)
            {
                arr2[i] = arr[1, i];
            }
            Console.Write("Наибольшее значение во второй строке массива равно: ");
            Console.WriteLine(arr2.Max());
            int[] arr3 = new int[3];
            for (int i = 0; i < 3; i++)
            {
                arr3[i] = arr[2, i];
            }
            Console.Write("Наибольшее значение в третьей строке массива равно: ");
            Console.WriteLine(arr3.Max());
        }

        static void trarr2()
        {/*Задание 14: Напишите программу, которая создает двумерный массив 4x4 и транспонирует его.*/
            Random rand = new Random();
            int[,] arr = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = rand.Next(0, 10);
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    int a = arr[i, j];
                    arr[i, j] = arr[j, i];
                    arr[j, i] = a;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void prarr()
        {/*Задание 15: Напишите программу, которая умножает две двумерные матрицы размером 2x2.*/
            Random rand = new Random();
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr1[i, j] = rand.Next(0, 10);
                    Console.Write(arr1[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr2[i, j] = rand.Next(0, 10);
                    Console.Write(arr2[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] arr = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr[i, j] = arr1[i, j] * arr2[i, j];
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void obarr() // ДОДЕЛАТЬ 
        {/*Задание 16: Напишите программу, которая находит обратную матрицу для матрицы 2x2. 
         Если обратная матрица не существует, программа должна вывести соответствующее сообщение.*/
            Random rand = new Random();
            int[,] arr = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr[i, j] = rand.Next(0, 10);
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] arr1 = new int[2, 2];
            int det = arr[0, 0] * arr[1, 1] - arr[0, 1] * arr[1, 0];
            if (det == 0)
            {
                Console.WriteLine("Обратной матрицы не существует");
            }
            if (det != 0)
            {

            }
        }

        static void parr()
        {/*Задание 17: Напишите программу, которая поворачивает двумерный массив 3x3 на 90 градусов по часовой стрелке.*/
            Random rand = new Random();
            int[,] arr = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = rand.Next(0, 5);
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] arr1 = new int[3, 3];
            arr1[0, 0] = arr[2, 0];
            arr1[0, 1] = arr[1, 0];
            arr1[0, 2] = arr[0, 0];
            arr1[1, 0] = arr[2, 1];
            arr1[1, 1] = arr[1, 1];
            arr1[1, 2] = arr[0, 1];
            arr1[2, 0] = arr[2, 2];
            arr1[2, 1] = arr[1, 2];
            arr1[2, 2] = arr[0, 2];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr1[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void srсols()
        {/* Задание 18: Напишите программу, которая вычисляет среднее арифметическое элементов в каждом столбце двумерного массива 3x3.*/
            Random rand = new Random();
            int[,] arr = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = rand.Next(0, 10);
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            int[] arr1 = new int[3];
            double a = 0;
            for (int i = 0; i < 3; i++)
            {
                arr1[i] = arr[i, 0];
                a += arr1[i];
            }
            Console.Write("Среднее арифметрическое первого столбца равно: ");
            Console.WriteLine(a / 3);
            int[] arr2 = new int[3];
            double b = 0;
            for (int i = 0; i < 3; i++)
            {
                arr2[i] = arr[i, 1];
                b += arr2[i];
            }
            Console.Write("Среднее арифметическое второго столбца равно: ");
            Console.WriteLine(b / 3);
            int[] arr3 = new int[3];
            double c = 0;
            for (int i = 0; i < 3; i++)
            {
                arr3[i] = arr[i, 2];
                c += arr3[i];
            }
            Console.Write("Среднее арифметическое третьего столбца равно: ");
            Console.WriteLine(c / 3);
        }

        static void umarr()
        {/*Задание 19: Напишите программу, которая умножает каждый элемент двумерного массива 3x3 на заданное число.*/
            Random rand = new Random();
            int[,] arr = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = rand.Next(1, 15);
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int x;
            do
            {
                Console.WriteLine("На какое число хотетите умножить массив?");
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("На 0 умножать нельзя!");
                }
            } while (x == 0);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = arr[i, j] * x;
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }

        static void mininarr()
        {/*Задание 20: Напишите программу, которая находит минимальный элемент в каждой строке двумерного массива 3x3.*/
            Random rand = new Random();
            int[,] arr = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = rand.Next(0, 50);
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            int[] arr1 = new int[3];
            for (int i = 0; i < 3; i++)
            {
                arr1[i] = arr[0, i];
            }
            Console.Write("Наименьшее значение в первой строке массива равно: ");
            Console.WriteLine(arr1.Min());
            int[] arr2 = new int[3];
            for (int i = 0; i < 3; i++)
            {
                arr2[i] = arr[1, i];
            }
            Console.Write("Наименьшее значение во второй строке массива равно: ");
            Console.WriteLine(arr2.Min());
            int[] arr3 = new int[3];
            for (int i = 0; i < 3; i++)
            {
                arr3[i] = arr[2, i];
            }
            Console.Write("Наименьшее значение в третьей строке массива равно: ");
            Console.WriteLine(arr3.Min());
        }

    }
    /*Задание 21: Класс для представления человека
    Создайте класс Person, который будет содержать следующие поля: имя, возраст, пол.Добавьте методы для вывода информации
    о человеке и увеличения возраста.*/

    class Person
    {
        public string name;
        public int age;
        public string sex;

        public Person(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public void set(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }
        public void printinfo()
        {
            Console.WriteLine($"Имя:{name}\nВозраст:{age}\nПол:{sex}\n");
        }

        public void uage()
        {
            Console.WriteLine("Какой сейчас год?");
            int a = int.Parse(Console.ReadLine());
            int x = a - 2024;
            Console.Write("Насте сейчас ");
            Console.WriteLine(age + x);
        }
    }

}
