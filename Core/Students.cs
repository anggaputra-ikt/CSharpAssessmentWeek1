namespace Core
{
    public class Students
    {
        public string Name { get; set; }
        public Scores Scores { get; set; }
        public void GetAssessmentScores(string name, double midtermTest, double finalTest, List<double>quizScores)
        {
            Name = name;
            Scores = new Scores();
            Scores.MidtermTest = midtermTest;
            Scores.FinalTest = finalTest;
            Scores.QuizScores = quizScores;
            List<double> highestScores = Scores.HighestScores;
            double finalScores = Scores.FinalScores;
            char letterGrade = Scores.LetterGrade;
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Highest Scores: {highestScores}");
            Console.WriteLine($"Final Scores: {finalScores}");
            Console.WriteLine($"Letter Grade: {letterGrade}");
        }
    }
}