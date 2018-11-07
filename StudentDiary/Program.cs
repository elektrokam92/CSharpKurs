using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            for (; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu 1-10: ");

                float rating;

                bool result = float.TryParse(Console.ReadLine(), out rating);

                if (rating == 11) break;

                if (result)
                {
                    diary.AddRating(rating);

                }
            }
            
            Console.WriteLine("Średnia ocen= " + diary.CalculateAverage());
            Console.WriteLine("Najwyższa ocena= " + diary.GiveMaxRating());
            Console.WriteLine("Najniższa ocena= " + diary.GiveMinRating());
            Console.ReadKey();

        }
    }
}
