using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace SelectionStatementExercise
{
    public class Program
    {
        public static bool CheckUserGuess(int guess, int magicNum)
        {
            if (guess > magicNum)
            {
                Console.WriteLine("Your guess is to high. Guess again.");
                return false;
            }
            else if (guess < magicNum)
            {
                Console.WriteLine("Your guess is too low. Guess again.");
                return false;
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number.");
                Console.WriteLine($"The magic number was {magicNum}.");
                Console.WriteLine("Thanks for playing!");
                return true;
            }
        }


        static void Main(string[] args)
        {
            var r = new Random();
            int magicNum = r.Next(1, 101);
       

            Console.WriteLine("\t\t   Welcome To");
            Console.WriteLine("\t   - Guess the Magic Number -\n");
            Console.WriteLine("I have a magic number between 1 & 100 stored in memory.\n\t  Can you guess the magic number?");
            Console.WriteLine("\t(type in your guess and press ENTER)\n");
            Console.Write(">>> ");
            var userGuess = int.Parse(Console.ReadLine());

            bool endGame = CheckUserGuess(userGuess, magicNum);

            while (endGame == false)
            {
                if (endGame == false)
                {
                    Console.Write(">>> ");
                    userGuess = int.Parse(Console.ReadLine());
                    endGame = CheckUserGuess(userGuess, magicNum);

                }
                else
                {
                    break;                }
            }
        }
    }
}
