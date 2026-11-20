using System;
using System.Collections.Generic;
using System.IO;
using SmartQuiz.Models;
using SmartQuiz.Services;

namespace SmartQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuizManager manager = new QuizManager();

            string[] lines = File.ReadAllLines("questions.txt");

            
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue; 

               
                string[] parts = line.Split('|');

                
                if (parts[0] == "MC")
                {
                    string qText = parts[1];
                    int score = Convert.ToInt32(parts[2]);
                    string correct = parts[3];

                    
                    string[] optionsArray = parts[4].Split(',');
                    List<string> optionsList = new List<string>(optionsArray);

                    
                    MultipleChoiceQuestion mcQuestion = new MultipleChoiceQuestion(qText, score, correct, optionsList);
                    manager.AddQuestion(mcQuestion);
                }
                
                else if (parts[0] == "TF")
                {
                    string qText = parts[1];
                    int score = Convert.ToInt32(parts[2]);
                    string correct = parts[3];

                    TrueFalseQuestion tfQuestion = new TrueFalseQuestion(qText, score, correct);
                    manager.AddQuestion(tfQuestion);
                }
            }

            Console.WriteLine("--- Quiz Started ---");
            manager.StartQuiz();

            Console.WriteLine("\n--- Quiz Finished");
            Console.ReadLine();
        }
    }
}


