// modellen som skapar alla enskilda items

// modellen som skapar alla enskilda items

using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedWebArcitechture_ConsoleQuiz
{
    public class QuizItem   // modellen
    {
        public string Question { get; set; }

        // Creates a list for all answers
        public List<String> Answers { get; set; } = new List<string>();
        public int CorrectAnswer { get; set; }

        // Constructor
        public QuizItem(string question, string AnswerOne, string AnswerTwo, string AnswerThree, int correctAnswer)
        {
            // Adds all answers to the list
            Answers.Add(AnswerOne);
            Answers.Add(AnswerTwo);
            Answers.Add(AnswerThree);

            Question = question;
            CorrectAnswer = correctAnswer;
        }

    }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedWebArcitechture_ConsoleQuiz
{
    public class QuizItem   // modellen
    {
        // properties med: fråga, svar och indikator för vad som är rätt svar

        // Property
        public string Question { get; set; }
        /*public string WrongAnswerOne { get; set; }
        public string WrongAnswerTwo { get; set; }*/
        /*
        public string CorrectAnswer { get; set; }

        // Constructor
        
        public QuizItem(string question, string wrongAnswerOne, string wrongAnswerTwo, string correctAnswer)
        {
            Question = question;
            WrongAnswerOne = wrongAnswerOne;
            WrongAnswerTwo = wrongAnswerTwo;
            CorrectAnswer = correctAnswer;
        }

    }
}*/
