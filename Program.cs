using System;

namespace QuestionGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Austin is dumb");
        }
        
         public static int AskQuestion(Question question);
         {
            if (question.answers == null) throw new ArgumentNullException("List of answers may not be null");
            if (question.answers.Count == 0) throw new ArgumentException("There should be at least 1 answer in the list");
            int index = 1;
            Console.WriteLine($"{question.question}");
            foreach (string answers in question.answers)
            {
                Console.WriteLine($"{index}. {answers}");
                index = index + 1;

            }
         }
        
    }

}
