//@author J-Schuller

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_17_inclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favorite baseball team?");
            string answer = Console.ReadLine().ToUpper().Trim(); // Trim takes the spaces out of it
            string nextAnswer = "Somethine else";
            string answerUppercase = answer.ToUpper();


            for (int i = 0; i < answerUppercase.Length; i++)
            {
                Console.Write(answerUppercase[i] + " ");
            }

            Console.WriteLine($"Your favorite team has {answer.Length} characters in it");







            Console.ReadKey();
        }
    }
}
