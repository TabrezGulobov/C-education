using System;

namespace ConsoleApp7

{
    class Pogram
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count = 0;
            while (a >= b)
            {
                a -= b;
                count++; 
            }
            Console.WriteLine(count);
        }
    }
}