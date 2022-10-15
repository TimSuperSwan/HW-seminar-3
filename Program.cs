using System;

namespace Семинар3дз
{
    class Program
    {
        static void Main(string[] args)
        {
            //__________Домашнее задание к 3 семинару______________

            /*Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
            является ли оно палиндромом. (можно решить через строку, а можно математически)*/

            /*
            Console.WriteLine("Введите пятизначное число");
            string Num = Console.ReadLine();
            if (Num[0]==Num[4] && Num[1] == Num[3])
            {
                Console.WriteLine("Число является полиндромом");
            }
            else
            {
                Console.WriteLine("Число не является полиндромом");
            }
            */


            //Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

            /*
            Console.WriteLine("Введите координату Х первой точки");
            double X1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y первой точки");
            double Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Z первой точки");
            double Z1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату X первой точки");
            double X2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y второй точки");
            double Y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Z второй точки");
            double Z2 = Convert.ToDouble(Console.ReadLine());

            double result = Math.Sqrt(Math.Pow(X2-X1,2) + Math.Pow(Y2-Y1,2) + Math.Pow(Z2-Z1,2));
            Console.WriteLine($"{result:f2}");
            */

            //Задача 23   Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            
            /*
            Console.WriteLine("Введите число");
            int Num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Num; i++)
            {
                int result = Convert.ToInt32 (Math.Pow(i,3));
                Console.Write($"{result}, ");
            }
            */
        //_______________________________Домашнее задание к 4 семинару_____________________________________

        /*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
        3, 5 -> 243 (3⁵)
        2, 4 -> 16 */

        /*
        Console.WriteLine("Введите число");
        int a =int.Parse(Console.ReadLine());
        Console.WriteLine("Введите степень");
        int b =int.Parse(Console.ReadLine());

        int Deg (int A, int B)
        {
            int result=A;
            for (int i = 1; i < B; i++)
            {
                result = result*A;  
            }
            return result;

        }
        Console.WriteLine($"{a}, {b} -> {Deg(a,b)}");
        */

        /*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        452 -> 11
        82 -> 10
        9012 -> 12 */

        /*
        Console.WriteLine("Введите число");
        string Num = Console.ReadLine();

        int Summa(string A)
        {
            int result = 0;
            int a = int.Parse(A);
            int i = 0;
            while (A.Length > i)
            {
                result = result + a%10; 
                a = a / 10; 
                i = i + 1;              
            } 
        return result;
        }

        Console.WriteLine($"Сумма цифр числа {Num} = {Summa(Num)}");

        */


        /*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
        1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
        6, 1, 33 -> [6, 1, 33]*/

        /*
        Console.WriteLine("Введите размер массива");
        int NumArray = int.Parse(Console.ReadLine()!);

        int[] Array(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0,10);
            }
            return array;
        }

        int[] res = Array(NumArray);
        Console.WriteLine($"[{String.Join(", ", res)}]");
        */



         
        












        }
    }
}
