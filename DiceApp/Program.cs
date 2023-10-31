namespace DiceApp
{
    internal class Program
    {
        private static readonly int MIN = 1;
        private static readonly int MAX = 6;
        private static readonly int MAX_TRIES = 3;

        static void Main(string[] args)
        {
            var die = new Die();
            int guess;
            bool found = false;

            Console.WriteLine("Die Rolled. Guess the number in 3 tries:");
            for (int i = 1; i <= MAX_TRIES ; i++)
            {
                guess = Guess();
                if (guess == die.Side)
                {
                    Console.WriteLine("You are correct");
                    found = true;
                    break;
                }
                else
                {
                    Console.WriteLine(i < 3 ? "No. Try one more time." : "You lost.");
                }
            }

            if (!found)
            {
                Console.WriteLine($"The die was {die.Side}.");
            }
        }

        private static int Guess()
        {
            int input;
            bool isParsed;

            do
            {
                isParsed = int.TryParse(Console.ReadLine(), out input);
                if (isParsed == false)
                {
                    Console.WriteLine("You did not provided a number. Try again.");
                } 
                else if (input < MIN || input > MAX)
                {
                    Console.WriteLine("You must provide a number greater or equal than 1 and less or equal than 6. Try again.");
                }
                    
            } while (isParsed == false || input < MIN || input > MAX);

            return input;
        }
    }
}