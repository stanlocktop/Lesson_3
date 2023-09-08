using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет;
        Console.Write("Введіть номер місяця від 1 до 12 --> ");
        Console.ResetColor(); // сбрасываем в стандартный
        int month = int.Parse(Console.ReadLine());

        string season;

        if (month >= 1 && month <= 12)
        {
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Зима";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Весна";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Літо";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Осінь";
                    break;
                default:
                    season = "Немає такого місяця на цій планеті";
                    break;
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue; // устанавливаем цвет;
            Console.WriteLine($"Сезон: {season}");
            Console.ResetColor(); // сбрасываем в стандартный
        }
        else
        {
            Console.WriteLine("Номер місяця має бути від 1 до 12.");
        }
        Thread.Sleep(100000);
    }
}
