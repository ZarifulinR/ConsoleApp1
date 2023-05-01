using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение : ");
            decimal a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите процент : ");
            int b;

            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());

            Console.WriteLine(System.Math.Round(a * b / 100));

        }
    }
}
