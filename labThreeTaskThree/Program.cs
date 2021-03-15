﻿using System;

namespace labThreeTaskThree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите точность: ");
            double epsilon = double.Parse(Console.ReadLine());

            double term;
            double nextTerm;

            for (int k = 2; ;)
            {
                term = GetMember(k);
                nextTerm = GetMember(++k);

                if (Math.Abs(nextTerm - term) < epsilon)
                    break;
            }

            Console.WriteLine("Первый член числовой последовательности," +
                " удовлетворяющий условиям равен: " + nextTerm);

            Console.ReadLine();
        }

        public static double GetMember(int k)
        {
            double term = 1 + Math.Pow((-1), (k - 1)) / GetFactorial(k);

            if (k == 2)
                return term;

            else return term * GetMember(--k);
        }

        public static int GetFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            else return n * GetFactorial(--n);
        }
    }
}