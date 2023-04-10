using System;

namespace EvenOrOdd
{
    class Program
    {
        // Первый вариант
        public static string EvenOrOdd1(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }

        // Второй вариант
        public static string EvenOrOdd2(int number)
        {

            if (number % 2 == 0)
            {
                return ("Even");
            }
            else
            {
                return ("Odd");
            }
        }
        // Третий вариант
        public static string EvenOrOdd3(int number)
         => number % 2 == 0 ? "Even" : "Odd";

        // Четвертый вариант
        public static Func<int, string> EvenOrOdd4 = (x) => x % 2 == 0 ? "Even" : "Odd";

        // Пятый вариант
        public static string EvenOrOdd5(int number)
        {
            return new string[] { "Even", "Odd" }[number % 2];
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
