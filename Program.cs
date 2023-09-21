using System;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string again = "aaa";
            System.Random rnd = new System.Random();

            while (again != "n")
            {

            int num = 0;
            string answer;
            int score = 0;
            string input;
            int times;


            Console.Clear();
            Console.WriteLine("Welcome to the times table test!");
            Console.WriteLine("What's your name? ");
            string name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Hi {0}, what times table would you like to be tested on?", name);


            while (true)
            {
                input = Console.ReadLine();
                Console.WriteLine("Hi {0}, what times table would you like to be tested on?", name);
                try
                {
                    times = Convert.ToInt32(input);

                    if  (times > 1 || times < 12)
                    {
                        break;
                    }

                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Make sure you enter a number between 1 - 12");
                }
            }

            Console.Clear();
            Console.WriteLine("Press enter when you are ready to play!");
            Console.ReadKey();

            Console.Clear();

            for (int i=0; i < 11; i++)
            {
                num = rnd.Next(1, 13);
                Console.WriteLine("What is {0} x {1}?", num, times);
                answer = Console.ReadLine();

                if (Convert.ToInt32(answer) == (num * times))
                {
                    Console.WriteLine("\nCorrect!");
                    score++;
                }

                else
                {
                    Console.WriteLine("\nIncorrect!");
                }
            }

            Console.Clear();

            Console.WriteLine("You had a score of {0} out of 10!", score);

            if (score < 3)
            {
                Console.WriteLine("Thats kinda bad");
            }

            else if (score > 3 && score < 6)
            {
                Console.WriteLine("Thats alright");
            }

            else if (score > 6)
            {
                Console.WriteLine("Good!");
            }

            Console.WriteLine("Play again? (y/n)");
            again = Console.ReadLine();

            }

        }
    }
}
