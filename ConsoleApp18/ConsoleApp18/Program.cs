using System;

namespace ConsoleApp7

{
    class Pogram
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (a >= b)
            {
                a -= b;
            }
            Console.WriteLine(a);
        }
    }
}