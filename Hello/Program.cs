using System;

namespace Hello_
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (; ; )
            {
                Greeting();

                Age();
                Settings();
            }


            //foreach (var item in args)
            //{
            //    Console.WriteLine("Witaj, " + item);
            //}
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        /// <summary>
        /// Reset ustawień do domyślnych
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        /// <summary>
        /// Wypisujemy komunikat zależny od wieku
        /// </summary>
        private static void Age()
        {
            Console.Write("Wpisz ile masz lat:  ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if ((age < 18) & (age > 0))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Proszę mleko");
            }
            else if (result == false)
            {
                Console.WriteLine("Wpisałeś niepoprawny wiek, popraw to!!!");
            }
            else
            {
                Console.WriteLine("Proszę piwo");
            }
        }

        /// <summary>
        /// Wypisujemy powitanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje imię:  ");
            string name = Console.ReadLine();

            Console.WriteLine("witaj, " + name);
        }
    }
}
