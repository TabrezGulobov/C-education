using System;

class Program
{
    static void Main()
    {
       
        int unitNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите массу тела в выбранных единицах: ");
        double mass = double.Parse(Console.ReadLine());

        double massInKilograms = ConvertToKilograms(unitNumber, mass);
        Console.WriteLine($"Масса тела в килограммах: {massInKilograms}");
    }

    static double ConvertToKilograms(int unitNumber, double mass)
    {
        switch (unitNumber)
        {
            case 1: 
                return mass;
            case 2: 
                return mass / 1_000_000;
            case 3: 
                return mass / 1_000;
            case 4: 
                return mass * 1_000;
            case 5: 
                return mass * 100;
            default:
                throw new ArgumentException("Неверный номер единицы массы");
        }
    }
}