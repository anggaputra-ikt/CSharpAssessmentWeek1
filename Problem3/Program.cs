namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public List<string> SplitTextInToSentence(string text)
        {
            return text.Split(new[] {' '}).ToList();
        }
    }
}