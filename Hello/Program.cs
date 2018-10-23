using System;

namespace Hello_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wpisz swoje imię:  ");
            string name = Console.ReadLine();

            Console.WriteLine("witaj, " + name);

            Console.Write("Wpisz ile masz lat:  ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

                if ((age < 18) & (age > 0))
                {
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

            Console.ReadKey();

            //foreach (var item in args)
            //{
            //    Console.WriteLine("Witaj, " + item);
            //}
        }
    }
}
