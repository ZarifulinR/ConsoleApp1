using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 100");
           int a ;
            a = Convert.ToInt32(Console.ReadLine()); 
           
            Console.WriteLine (a.GetType());
            if (a > 100 || a < 1)
            {
                Console.WriteLine("Erorr");

             Environment.Exit(0);
            }
            if (a % 3 == 0)
            {
                Console.WriteLine("Fizz");
               
            }
            
            if (a%5==0)
            {
                Console.WriteLine("Buzz");
               
            }
             if (a % 3 == 0 || a % 5 == 0)
            {
                Console.WriteLine("FizzBizz");
            }
            else Console.WriteLine(a);
            
            

        }
    }
}
