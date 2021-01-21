using System;

namespace Assignment_5_Student_Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] toysScores = { 7, 6, 5, 4, 3 };
            Student Toy = new Student("Toy", 12, toysScores);
            Console.WriteLine(Toy.GetAverage());
            Console.WriteLine(Toy.GetHighest());
            Console.WriteLine(Toy.GetLowest());

            Student intouch = new Student("Intouch", 12, 7, 7, 3, 2, 5);
            Console.WriteLine(intouch.GetAverage());
            Console.WriteLine(intouch.GetHighest());
            Console.WriteLine(intouch.GetLowest());
            int[] intouchScores = intouch.GetScores();
            Console.WriteLine(intouchScores[0]);
            for(int i = 0; i < intouchScores.Length; i++)
            {
                Console.WriteLine(intouchScores[i]);
            }
        }
    }
}
