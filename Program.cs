using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to game random number");
            Console.Write("What's your name ? : ");
            Console.ResetColor();
            string name_user = Console.ReadLine();
            Console.WriteLine("Hello {0} , let's play game...", name_user);
            number_game();

        }

        private static void number_game()
        {
            Random rnd = new Random();
            int Number = rnd.Next(1, 10); ;
            int guess=1000;
            Console.Write("Guess a number 1-10 : ");
            while ( guess != Number)
            {
                string input_game = Console.ReadLine();  
                Int32.TryParse(input_game, out guess);
                Console.WriteLine();
                if (guess != Number)
                {
                    Console.WriteLine("Worng! number,please try again");
                    Console.Write("Guess a number 1-10 : ");
                }
                if(guess == Number)
                {
                    Console.WriteLine("Success!!");
                }
            }
        }
    }
}
