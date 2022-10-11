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

        }
    }
}
