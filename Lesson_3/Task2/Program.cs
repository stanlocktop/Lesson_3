namespace Task2
{
   //2) Необхідно написати консольну програму, де користувач вводитиме з клавіатури 2 числа.Числа будуть порівнюватися з наступним виведенням в консоль результату цього порівняння(чи рівні значення, а якщо ні, яке число більше/менше).
    public class Example
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введіть 1 число: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введіть 2 число: ");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Числа рівні");
            }
            else 
            if (num1 > num2)
            {
                Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                
                Console.WriteLine($"Число {num1} більше за число {num2}!");
                Console.ResetColor(); // сбрасываем в стандартный
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                Console.WriteLine($"Число {num1} менше за число {num2}!");
                Console.ResetColor(); // сбрасываем в стандартный
            }
            Console.ReadKey();
        }
    }
}
