using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст вашей девушки: ");
            string text = Console.ReadLine();
            int years = Convert.ToInt32(text);
            if (years > 16)
            {
                Console.WriteLine("Тогда все ОК");

            }
            else
            {
                Console.WriteLine("Мужик у тебя проблемы, я вызвал полицию");
            }
            Console.ReadKey();
        }
    }
}
