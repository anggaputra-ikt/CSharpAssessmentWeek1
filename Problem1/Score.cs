using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Problem1
{
    public class Score
    {
        public double MidtermTest { get; set; }
        public double FinalTest { get; set; }
        public List<double> QuizScores = new List<double>(); // Reference Type
        private double CalculateAverageOfThreeHighestScores()
        {
            List<double> result = new List<double>();
            List<double> quizScores = QuizScores.ToList();  // Reference Type
            int loopIndex = 0;
            while (loopIndex != 3)
            {
                double maxValue = quizScores.Max();
                int indexMaxValue = quizScores.IndexOf(maxValue);
                if (result.Any(x => x == maxValue) == false)
                {
                    result.Add(maxValue);
                    loopIndex += 1;
                }
                quizScores[indexMaxValue] = 0;
            }

            return result.Average();
        }
        public double FinalScore
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
                return GradingScale(FinalScore);
            }
        }
        private double GetFinalScores()
        {
            return MidtermTest*0.3 + FinalTest*0.4 + CalculateAverageOfThreeHighestScores()*0.3;
        }
        private char GradingScale(double scores)
        {
            if (scores <= 45 && scores >= 0)
            {
                return 'F';
            }
            else if (scores <= 50)
            {
                return 'E';
            }
            else if (scores <= 60)
            {
                return 'D';
            }
            else if (scores <= 70)
            {
                return 'C';
            }
            else if (scores <= 80)
            {
                return 'B';
            }
            else if (scores <= 100)
            {
                return 'A';
            } else
            {
                return 'F';
            }
        }
    }
}
