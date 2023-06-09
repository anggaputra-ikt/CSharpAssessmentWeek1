namespace Problem1
{
    public class Student
    {
        public string Name { get; set; }
        public Score Score { get; set; }
        public void GetAssessmentScores()
        {
            Console.WriteLine($"Student Name: {Name}");
            //Console.WriteLine($"Highest Scores: {highestScores[0]}, {highestScores[0]}, {highestScores[0]}");
            Console.WriteLine($"Final Scores: {Score.FinalScore}");
            Console.WriteLine($"Letter Grade: {Score.LetterGrade}");
        }
    }
}