using System;
using System.Collections.Generic;

class Meteo
{
    public string ДеньТижня { get; set; }
    public int Температура { get; set; }
    public int Опади { get; set; }

    public string GetValuesString()
    {
        return $"{ДеньТижня} - Температура: {Температура}, Опади: {Опади}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Meteo> meteoList = new List<Meteo>();

        // Ввід даних з клавіатури
        Console.WriteLine("Введіть дані для кожного дня:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"День ");
            Console.Write("День тижня: ");
            string деньТижня = Console.ReadLine();
            Console.Write("Температура: ");
            int температура = Convert.ToInt32(Console.ReadLine());
            Console.Write("Опади: ");
            int опади = Convert.ToInt32(Console.ReadLine());

            Meteo meteo = new Meteo
            {
                ДеньТижня = деньТижня,
                Температура = температура,
                Опади = опади
            };

            meteoList.Add(meteo);
        }

        // Виведення списку на екран
        Console.WriteLine("Список даних:");
        foreach (Meteo meteo in meteoList)
        {
            Console.WriteLine(meteo.GetValuesString());
        }

        // Знайти кількість днів зі снігом (температура 0 і нижче)
        int кількістьднівзіснігом = 0;
        foreach (Meteo meteo in meteoList)
        {
            if (meteo.Температура <= 0)
            {
                кількістьднівзіснігом++;
            }
        }
        Console.WriteLine($"Кількість днів зі снігом: {кількістьднівзіснігом}");

        // Знайти загальну кількість опадів у дощі
        int загальна_кількість_опадів_у_дощі = 0;
        foreach (Meteo meteo in meteoList)
        {
            if (meteo.Температура > 0)
            {
                загальна_кількість_опадів_у_дощі += meteo.Опади;
            }
        }
        Console.WriteLine($"Загальна кількість опадів у дощі: {загальна_кількість_опадів_у_дощі}");

        Console.ReadLine();
    }
}
