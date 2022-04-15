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
        //Ask question and once you get the answer display the response
        /// <summary>
        /// Ask question and once you get the answer display the response
        /// </summary>
        /// <param name="prompt">The question that is being asked</param>
        /// <returns>It returns the answer to the player</returns>
        public static string MakeUserSmart(string prompt)
        {

            List<string> NORESPONSES = new List<string>();

            NORESPONSES.Add("GENIUS!");
            NORESPONSES.Add("YOU'RE JUST TOO SMART");
            NORESPONSES.Add("CORRECT");



            List<string> YESRESPONSES = new List<string>();

            YESRESPONSES.Add("YOU'RE WRONG");
            YESRESPONSES.Add("INCORRECT");

            string Response;
            Random generator = new Random();

            int YESIndex = generator.Next(0, YESRESPONSES.Count);
            string randomYESRESPONSE = YESRESPONSES[YESIndex];

            Response = $"{randomYESRESPONSE}";

            string Response1;
            Random generator1 = new Random();

            int NOIndex = generator.Next(0, NORESPONSES.Count);
            string randomNORESPONSE = NORESPONSES[NOIndex];

            Response1 = $"{randomNORESPONSE}";
            string input;
            do
            {
                Console.WriteLine($"{prompt}");
                input = Console.ReadLine().ToLower();

                if (input == "no")
                {
                    Console.WriteLine($"{randomNORESPONSE}");
                }
                else if (input == "yes")
                {
                    Console.WriteLine($"{randomYESRESPONSE}");
                }
                if (input == null) throw new Exception("Please answer yes or no");
            }
            while((input == "yes" || input == "no") == false);

            return input;

        }

    }

}
