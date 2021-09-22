using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.WriteLine("1 ci eded");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2 ci eded");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2=temp ;
            Console.WriteLine("Sonra");
            Console.WriteLine("1ci eded"+number1);
            Console.WriteLine("2ci eded"+number2);


        }
    }
}
