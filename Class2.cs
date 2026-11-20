
namespace SmartQuiz.Models
{
    
    public class User
    {
        public string UserName { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            UserName = name;
            Age = age;
        }
    }
    public abstract class Questions
    {
        public string CorrectAnswer {  get; set; }
        public string Question { get; set; }
        public int Score { get; set; }

        public Questions(string question, int score, string correctanswer) 
        {
            Question = question;
            Score = score;
            CorrectAnswer = correctanswer;
        }

        public abstract void Ask();
    }

    public class MultipleChoiceQuestion : Questions
    {
        public List<string> Options = new List<string>();
        public MultipleChoiceQuestion(string question, int score, string correctanswer, List<string> options) : base(question, score, correctanswer)
        {
            Options = options;
        }
        public override void Ask()
        {
            Console.WriteLine(Question);


            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Options[i]}");
            }
        }
    }

    public class TrueFalseQuestion : Questions
    {
        public TrueFalseQuestion(string question, int score, string correctanswer) : base(question, score, correctanswer)
        {

        }
        
        public override void Ask()
        {
            Console.WriteLine($"True Or False: {Question}");

        }
    }
}
