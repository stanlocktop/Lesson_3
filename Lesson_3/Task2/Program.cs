namespace Task1

{
    //1) Дано тризначне число.Знайти число, отримане під час прочитання його цифр справа наліво.
    public class Example
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть тризначне число, яке хочете прочитати справа наліво: ");
            Console.WriteLine(string.Concat(Console.ReadLine().Reverse()));
            Console.ReadKey();
        }
    }
}
