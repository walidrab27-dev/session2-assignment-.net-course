namespace Assessment_1;

class Program
{

    static Random random = new Random();

    static int RandomNumber()
    {
        return random.Next(1, 101);
    }

    static void CheckNumber(ref int attempts, int totalAttempts, int PcNumber, int tries)
    {
        while (attempts > 0)
        {
            Console.WriteLine($"Attempt {++tries}/{totalAttempts} - Enter your guess : ");
            bool isValid = int.TryParse(Console.ReadLine(), out int userNumber);

            if (!isValid)
            {
                Console.WriteLine("\n❌ Invalid input. Please enter a number.");
                userNumber = Convert.ToInt32(Console.ReadLine());
            }

            if (userNumber < 1 || userNumber > 100)
            {
                Console.WriteLine("\n⚠️ Please enter a number between 1 and 100.");
                userNumber = Convert.ToInt32(Console.ReadLine());
            }

            if (userNumber < PcNumber)
                Console.WriteLine("📉 Too low! Try again.\n\n");
            else if (userNumber > PcNumber)
                Console.WriteLine("📈 Too high! Try again.\n\n");
            else
            {
                Console.WriteLine("🎉 Congratulations! You guessed the correct number!");
                break;
            }
            attempts--;
        }

        if (attempts == 0)
            Console.WriteLine($"❌ Game over! The correct number was {PcNumber}");
        Console.WriteLine();
    }

    static void RunGame()
    {

        int PcNumber = RandomNumber(), attempts = 5, tries = 0, totalAttempts = attempts;
        Console.WriteLine("I have chosen a number between 1 and 100.");
        Console.WriteLine($"You have {attempts} attempts to guess it.");
        Console.WriteLine("\n");
        CheckNumber(ref attempts, totalAttempts, PcNumber, tries);
    }

    static void Main(string[] args)
    {
        RunGame();

    }
}
