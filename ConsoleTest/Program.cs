using System;
using System.Collections.Generic;
using System.IO;
using ConsoleTest.Classes;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple a1 = new Apple("Красное яблоко", 100, 100);
            Apple a2 = new Apple("Зеленое яблоко", 90, 110);

            Apple a3 = a1 + a2;
            Console.WriteLine(a1);
            Console.WriteLine("---");
            Console.WriteLine(a2);
            Console.WriteLine("---");
            Console.WriteLine(a3);
        }
    }
}
