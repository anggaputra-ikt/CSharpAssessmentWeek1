namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer jonny = new Customer()
            {
                Name = "Jonny",
                Loan = new Loan()
                {
                    LoanAmount = 1000000,
                    RatePerPeriod = 0.15,
                    NumberOfPeriods = 12,
                }
            };
            Console.WriteLine($"Pinjaman Bulanan {jonny.Name}: {jonny.Loan.Payment}");
        }
    }
}