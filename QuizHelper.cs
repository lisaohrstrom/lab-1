// samlar alla items from QuizItem.cs i en lista som vi kan loopa igenom i Program.cs (kolla lektion 2 slidesen)
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedWebArcitechture_ConsoleQuiz
{
    public static class QuizHelper
    {
        public static List<QuizItem> GetAllQuizItems()
        {
            var quizItemsList = new List<QuizItem>();

            quizItemsList.Add(new QuizItem("What is Lisa's name?", "1. Lina", "2. Lisa", "3. Melissa", 2));
            quizItemsList.Add(new QuizItem("How old is Lisa?", "1. Too old...", "2. Too young...", "3. Perfectly old yet young!", 3));
            quizItemsList.Add(new QuizItem("In what City was Lisa born?", "1. Jönköping", "2. Göteborg", "3. Borås", 3));
            quizItemsList.Add(new QuizItem("What sport has Lisa not played?", "1. Tennis", "2. Fotboll", "3. Innebandy", 1));
            quizItemsList.Add(new QuizItem("What's the name of Lisa's dad?", "1. Glenn", "2. Arne", "3. Ronny",  2));
            quizItemsList.Add(new QuizItem("What's the name of Lisa's mom?", "1. Anna", "2. Panna", "3. Sanna", 3));
            quizItemsList.Add(new QuizItem("What's the name of Lisa's brother?", "1. Anton", "2. Carl", "3. Hugo",  1));
            quizItemsList.Add(new QuizItem("What pet does Lisa own?", "1. Dog", "2. Cat", "3. Horse", 1));
            quizItemsList.Add(new QuizItem("What is the name of Lisa's dog?", "1. Björne", "2. Baxter", "3. Bosse", 2));
            quizItemsList.Add(new QuizItem("What course is Lisa's current favourite?", "1. Final Project Work in Informatics", "2. The course of life", "3. Applied Web Architecture", 3));

            return quizItemsList;
        }
    }
}
