namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            Console.Write("Введіть номер дня (1 - понеділок, ... 7 - неділя): ");
            Console.ResetColor(); // сбрасываем в стандартный
            int dayNumber = int.Parse(Console.ReadLine());

            string dayName;

            switch (dayNumber)
            {
                case 1:
                    dayName = "Понеділок";
                    break;
                case 2:
                    dayName = "Вівторок";
                    break;
                case 3:
                    dayName = "Середа";
                    break;
                case 4:
                    dayName = "Четвер";
                    break;
                case 5:
                    dayName = "П'ятниця";
                    break;
                case 6:
                    dayName = "Субота";
                    break;
                case 7:
                    dayName = "Неділя";
                    break;
                default:
                    dayName = "Не існує такого дня :)";
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
            Console.WriteLine($"День під номером {dayNumber} - це {dayName} :)");
            Console.ResetColor(); // сбрасываем в стандартный
            Console.ReadKey();
        }
    }
}