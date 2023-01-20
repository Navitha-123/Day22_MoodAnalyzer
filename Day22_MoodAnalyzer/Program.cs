namespace Day22_MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message;
            Random random = new Random();
            int mood = random.Next(2);

            if (mood == 1)
            {
                message = "Happy";
            }
            else
            {
                message = "Sad";

            }
            Console.WriteLine(UC1MoodAnalyzer.analyzeMood(message));
            Console.ReadLine();
        }
    }
}