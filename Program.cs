using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace QuestionGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you think Austin Ransford is cool");
            MakeUserSmart("Enter yes or no");
        }



        //Display the question to the user
        //Loop through each answer and display it
        //Using the GetValidAnswer method get and return the users response
        /// <summary>
        /// This displays the question and all of the answers and prompts the user to choose one the answers and returns the answer.
        /// </summary>
        /// <param name="question">The question that is being asked</param>
        /// <returns>It returns the answer to the player</returns>
        public static string MakeUserSmart(string prompt)
        {

            List<string> YESRESPONSES = new List<string>();
            YESRESPONSES = File.ReadAllLines("YES-Responses.txt").ToList();

            List<string> NORESPONSES = new List<string>();
            NORESPONSES = File.ReadAllLines("NO-Responses.txt").ToList();

            Console.WriteLine($"{prompt}");
            string input = Console.ReadLine().ToLower();
            if (input != "no")
            {
                Console.Error.WriteLine($"{NORESPONSES}");
            }
            else if (input == "yes")
            {
                Console.WriteLine($"{YESRESPONSES}");
            }

            while (input != "no" || input != "yes");
            do
            {
                Console.WriteLine("INVALID ANSWER");
                Console.WriteLine("Ill ask again. Do you think Austin Ransford is cool. ANSWER YES OR NO");
            }
        
            return input;

        }

    }

}
