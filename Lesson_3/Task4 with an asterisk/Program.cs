using System;
//4 *) Напишіть програму, яка приймає від користувача число від 1 до 100. При цьому якщо число кратне трьом, програма повинна виводити слово Fizz, а якщо кратно п'яти - слово Buzz. Якщо число кратно п'ятнадцяти, програма повинна виводити слово FizzBuzz. Завдання може здатися очевидним, але потрібно отримати найбільш просте та красиве рішення.
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет;
        Console.Write("Введіть число від 1 до 100 --> ");
        if (int.TryParse(Console.ReadLine(), out int num) && num >= 1 && num <= 100)
        {
            string result = "";

            if (num % 3 == 0)
                result += "Fizz";

            if (num % 5 == 0)
                result += "Buzz";

            if (result == "")
                result = "Число не підходить :(";

            Console.WriteLine(result);
            Console.ResetColor(); // сбрасываем в стандартный
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет;
            Console.WriteLine("Введене число не відповідає діапазону від 1 до 100!");
            Console.ResetColor(); // сбрасываем в стандартный
        }
        Thread.Sleep(100000);
    }
}
