namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "Test",
                Score = new Score()
                {
                    MidtermTest = 80,
                    FinalTest = 75,
                    QuizScores = new List<double>() { 85, 90, 80, 70, 95 },
                },
            };
            student.GetAssessmentScores();
        }
    }
}