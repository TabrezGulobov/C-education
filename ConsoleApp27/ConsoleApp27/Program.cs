namespace ConsoleApp27

{
    class Pogram
    {
        static void Main(string[] args)
        {
            // int 1f = 1;
            // int 2f = 1 * 2;
            // int 3f= 1 * 2 * 3;
            // int 4f = 1 * 2 * 4 ;
            // int n = 1 * 2 * 3...n ;
            //
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("error");
                return;
            }

           
            int i = 1;
            while (n >= 1)
            {
                i *= n;
                n -= 2;
            }
            Console.WriteLine($"Двойное фактериальное решение {i}");
        }
    }
}