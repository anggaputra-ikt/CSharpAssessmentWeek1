using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Loan
    {
        public decimal Payment
        {
            get
            {
                return CalculateLoanPayment();
            }
        }
        public decimal LoanAmount { get; set; }
        public double RatePerPeriod { get; set; }
        public int NumberOfPeriods { get; set; }
        public decimal CalculateLoanPayment()
        {
            // Casting
            decimal x = (decimal)RatePerPeriod * LoanAmount;
            decimal y = 1 - (decimal)Math.Pow((1 + RatePerPeriod), -(double)NumberOfPeriods);
            return x / y;
        }
    }
}
