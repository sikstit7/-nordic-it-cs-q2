using System;
using System.Threading;
namespace ДЗ1 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine($"Доброго дня,{name}");
            Thread.Sleep(5000);
            Console.WriteLine($"До скорых встречь,{name}");
            Console.ReadKey();
        }
    }
}
