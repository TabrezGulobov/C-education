// See https://aka.ms/new-console-template for more informatio

namespace ConsolrApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var D = a + 1;
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    if (D > 30)
                    {
                        Console.WriteLine("В этом месяце 31 дней");
                    }
                    else 
                    {
                        Console.WriteLine($"{D} Января");
                    }
                    ;
                        break;
                case "2":
                    if (D > 27)
                    {
                        Console.WriteLine("В этом месяце 28 дней");
                    }
                    else 
                    {
                        Console.WriteLine($"{D}Февраля");
                    }
                    ;
                    break;
                case "3":
                    if (D > 30)
                    {
                        Console.WriteLine("В этом месяце 31 дней");
                    }
                    else 
                    {
                        Console.WriteLine($"{D} Марта");
                    }
                    ;
                    break;
                case "4":
                    if (D > 29)
                    {
                        Console.WriteLine("В этом месяце 30 дней");
                    }
                    else 
                    {
                        Console.WriteLine($"{D} Апреля");
                    }
                    ;
                    break;
                case "5":
                    if (D > 30)
                    {
                        Console.WriteLine("В этом месяце 31 дней");
                    }
                    else 
                    {
                        Console.WriteLine($"{D} Мая");
                    }
                    ;
                    break;
                case "6":
                    if (D > 29)
                    {
                        Console.WriteLine("В этом месяце 30 дней");
                    }
                    else 
                    {
                        Console.WriteLine($"{D} Июня");
                    }
                    ;
                    break;
                case "7":
                    if (D > 30)
                    {
                        Console.WriteLine("В этом месяце 31 Июля");
                    }
                    else 
                    {
                        Console.WriteLine($"{D} Июля");
                    }
                    ;
                    break;
                case "8":
                    if (D > 29)
                    {
                        Console.WriteLine("В этом месяце 30 дней");
                    }
                    else 
                    {
                        Console.WriteLine($"{D} Августа");
                    }
                    ;
                    break;
                case "9":
                    if (D > 29)
                    {
                        Console.WriteLine("В этом месяце 30 дней");
                    }
                    else 
                    {
                        Console.WriteLine($"{D} Сентября");
                    }
                    ;
                    break;
                case "10":
                    if (D > 30)
                    {
                        Console.WriteLine("В этом месяце 31 дней");
                    }
                    else 
                    {
                        Console.WriteLine($"{D} Октября");
                    }
                    ;
                    break;
                case "11":
                    if (D > 29)
                    {
                        Console.WriteLine("В этом месяце 30 дней");
                    }
                    else 
                    {
                        Console.WriteLine($"{D} Ноябрья");
                    }
                    ;
                    break;
                case "12":
                    if (D > 30)
                    {
                        Console.WriteLine("В этом месяце 30 дней");
                    }
                    else 
                    {
                        Console.WriteLine($"{D} Декабрья");
                    }
                    ;
                    break;

            }
        }
    }
}

