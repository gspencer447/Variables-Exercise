namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Graham Spencer";
            int myAge = 28;
            char firstLetter = 'G';
            bool isCoding = true;
            double monthlyFee = 14.99;
            decimal hoursPlayed = 948.88357m;

            Console.WriteLine($"My name is {myName}. I am {myAge} years old and my name starts with the letter {firstLetter}. \n" +
                $"Right now, it is {isCoding} that I am taking a coding course. \n" +
                $"In my free time, I play a game that has a monthly subscription fee of ${monthlyFee}. \n" +
                $"Over my lifetime, I have accumulated {hoursPlayed} hours of playtime.");
        }
    }
}
