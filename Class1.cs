using System.Collections.Generic;
using System.Linq;
using SmartQuiz.Models;

namespace SmartQuiz.Services
{
  public class QuizManager
    {
        public QuizManager() 
        {
            QuizQuestions = new List<Questions>();
        }

        public void StartQuizSortedByScore()
        {
             
            List<Questions> sortedQuestions = QuizQuestions
                .OrderByDescending(q => q.Score)
                .ToList();

            
            foreach (Questions q in sortedQuestions)
            {
                q.Ask(); 

                Console.Write("Your answer: ");
                string userAnswer = Console.ReadLine();

                
                if (userAnswer.ToLower() == q.CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
                Console.WriteLine("-------------------------");
            }
        }

        public List<Questions> QuizQuestions { get; set; }
       
        public void AddQuestion(Questions q)
        {
            QuizQuestions.Add(q);
        }
        public void StartQuiz()
        {      
                int totalScore = 0; 

                
                foreach (Questions q in QuizQuestions)
                {
                    q.Ask();

                    Console.Write("Your answer: ");
                    string userAnswer = Console.ReadLine();


                if (userAnswer.ToLower() == q.CorrectAnswer.ToLower())
                {
                    Console.WriteLine("Correct! ");
                    totalScore += q.Score;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer is: {q.CorrectAnswer} ❌");
                }

                    Console.WriteLine("-------------------------");
                }

                
                Console.WriteLine($"Quiz Finished! Your Total Score: {totalScore}");
            
        }
    }
}
