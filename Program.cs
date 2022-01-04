/*
 * Rock, Paper, Scissors
 * Pawelski
 * 1/3/2022
 * Read the code and run the program a few times so you understand
 * what the program does and how it works. Once you understand what
 * the program does and how it works, modify the program so it
 * accomplishes the goal described on the activity sheet. Finally,
 * answer any questions on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerChoice;
            int computerChoice;
            // This creates a random number generator.
            Random ranNumberGenerator = new Random();
            // This uses the random number generator to generate a number
            // between 0 and 2. This number is stored in computerChoice.
            computerChoice = ranNumberGenerator.Next(1, 4);

            Console.Write("Rock, paper, or scissors >> ");
            playerChoice = Console.ReadLine();

            if (computerChoice == 1)
            {
                Console.WriteLine("CPU's choice: rock");
                if (playerChoice == "rock")
                {
                    Console.WriteLine("It was a tie!");
                }
                else if (playerChoice == "paper")
                {
                    Console.WriteLine("You won!");
                }
                else
                {
                    Console.WriteLine("You lost...");
                }
            }
            else if (computerChoice == 2)
            {
                Console.WriteLine("CPU's choice: paper");
                if (playerChoice == "rock")
                {
                    // Add your code here!
                }
                else if (playerChoice == "paper")
                {
                    // Add your code here!
                }
                else
                {
                    // Add your code here!
                }
            }
            else
            {
                Console.WriteLine("CPU's choice: scissors");
                // Add your code here!
            }

        }
    }
}
