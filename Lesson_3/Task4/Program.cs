using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.Write("Введіть номер місяця від 1 до 12: ");
        int month = int.Parse(Console.ReadLine());

        string season = GetSeason(month);

        if (season != "")
        {
            Console.WriteLine($"Сезон: {season}");
        }
        else
        {
            Console.WriteLine("Немає такого місяця на цій планеті :(");
        }
    }

    static string GetSeason(int month)
    {
        if (month >= 1 && month <= 12)
        {
            if (month == 12 || month <= 2)
                return "Зима";
            else if (month <= 5)
                return "Весна";
            else if (month <= 8)
                return "Літо";
            else
                return "Осінь";
        }
        return "";
    }
}