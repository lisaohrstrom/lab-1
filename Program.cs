using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedWebArcitechture_ConsoleQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###################################################");
            Console.WriteLine("Welcome to this really fun quiz application!");
            Console.WriteLine("###################################################");

            Console.WriteLine("Please enter your name:");
            var userName = Console.ReadLine();

            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Welcome " + userName + ", lets get started!\n");

            // Create new random number
            var random = new Random();
            var allQuizItems = QuizHelper.GetAllQuizItems();

            // Creates new list for the questions
            var quizQuestions = new List<QuizItem>();

            while (quizQuestions.Count < 5)
            {
                // Generates random question by using count to check whole list of questions
                var randomQuestion = allQuizItems.ElementAt(random.Next(0, allQuizItems.Count - 1));
                // Checks if random question is already in the list to avoid duplets (if it does not contain random question => add)
                if (!quizQuestions.Contains(randomQuestion))
                {
                    // populates the list with random question
                    quizQuestions.Add(randomQuestion);
                }
            }

            var i = 1;
            int score = 0;
            int questionNumber = 0;
            int totalQuestions = 5;
            int percentage;

            foreach (var quizItem in quizQuestions)
            {
                Console.WriteLine("\n" + i + ". " + quizItem.Question);
                i++;

                // foreach i foreachen för att loopa varje svar till varje fråga
                foreach (var answers in quizItem.Answers)
                {
                    Console.WriteLine("\t" + answers);
                }

                Console.WriteLine("\nYour answer: ");
                string userInput = Console.ReadLine(); 

                int value;

                while (!int.TryParse(userInput, out value) || Convert.ToInt32(userInput) > 3 || Convert.ToInt32(userInput) < 1) 
                {
                    Console.WriteLine("\nInvalid input, only 1, 2 or 3 is allowed.");
                    Console.WriteLine("Please try again:");
                    userInput = Console.ReadLine();
                }

                // Adds one to continue to the next question.
                questionNumber++;

                // If userInput is correct, add one to the score count.
                if (Convert.ToInt32(userInput) == quizItem.CorrectAnswer)
                {
                    score++;
                }

                if (questionNumber == totalQuestions)
                {
                    // Calculation of the percentage score
                    percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                    if (score <= 3)
                    {
                        Console.WriteLine("\n-----------------------------------------------------");
                        Console.WriteLine("You answered " + score + " out of 5 questions correctly.");
                        Console.WriteLine("Your percentage in score is: " + percentage + "%.");
                        Console.WriteLine("I'm sorry to tell you " + userName + ", but maybe you should try to get to know me better.");
                    }

                    if (score == 4)
                    {
                        Console.WriteLine("\n-----------------------------------------------------");
                        Console.WriteLine("You answered " + score + " out of 5 questions correctly.");
                        Console.WriteLine("Your percentage in score is: " + percentage + "%.");
                        Console.WriteLine("Hey " + userName + "! You are now considered a friend of mine :)");
                    }

                    if (score == 5)
                    {
                        Console.WriteLine("\n-----------------------------------------------------");
                        Console.WriteLine("You answered " + score + " out of 5 questions correctly.");
                        Console.WriteLine("Your percentage in score is: " + percentage + "%.");
                        Console.WriteLine("I'm impressed " + userName + "! You know everything about me! You are now considered my best friend :)");
                    }
                }
            }

            Console.WriteLine("\nPress any key to exit the quiz.");
            Console.ReadKey();
        }
    }
}
