using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Core
{
    public class Scores
    {
        public double MidtermTest { get; set; }
        public double FinalTest { get; set; }
        public List<double> QuizScores = new List<double>();
        public List<double> HighestScores => GetHighestScores();
        public List<double> GetHighestScores()
        {
            List<double> highestScores = QuizScores;
            foreach (double score in highestScores)
            {
                HighestScores.Add(score);
            }
            return HighestScores;
        }
        public double FinalScores
        {
            get
            {
                return GetFinalScores();
            }
        }
        public char LetterGrade
        {
            get
            {
                return GradingScale(FinalScores);
            }
        }
        public double GetFinalScores()
        {
            double midtermTest = MidtermTest * 0.3;
            double finalTest = FinalTest * 0.3;
            double quizScores = (HighestScores[0] + HighestScores[1] + HighestScores[3]) / 3 * 0.3;
            return midtermTest + finalTest + quizScores;

        }
        public char GradingScale(double scores)
        {
            if (scores >= 80 && scores <= 100)
            {
                return 'A';
            }
            else if (scores >= 70 && scores < 80)
            {
                return 'B';
            }
            else if (scores >= 60 && scores < 70)
            {
                return 'C';
            }
            else if (scores >= 50 && scores < 60)
            {
                return 'D';
            }
            else if (scores >= 45 && scores < 50)
            {
                return 'E';
            }
            else
            {
                return 'F';
            }
        }
    }
}
