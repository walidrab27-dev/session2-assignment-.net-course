namespace Assessment_3;

class Program
{
    static void ForLoop(int num)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        int fac = 1;
        for (int i = 1; i <= num; i++)
            fac *= i;
        Console.WriteLine($"Factorial of the number with For Loop: ");
        Console.WriteLine($"{num}! = {fac}" + "\n");
        Console.ResetColor();
    }

    static void WhileLoop(int num)
    {
        Console.ForegroundColor = ConsoleColor.White;
        int fac2 = 1, temp = num;
        while (temp >= 1)
        {
            fac2 *= temp;
            temp--;
        }
        Console.WriteLine($"Factorial of the number with While Loop: ");
        Console.WriteLine($"{num}! = {fac2}" + "\n");
        Console.ResetColor();
    }

    static void DoWhileLoop(int num)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        int fac3 = 1, temp2 = num;
        do
        {
            fac3 *= temp2;
            temp2--;
        } while (temp2 >= 1);
        Console.WriteLine($"Factorial of the number with Do-While Loop: ");
        Console.WriteLine($"{num}! = {fac3}" + "\n");
        Console.ResetColor();
    }

    static void Run()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Enter your nnumber please: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        ForLoop(num);
        WhileLoop(num);
        DoWhileLoop(num);
    }

    static void Main(string[] args)
    {
        Run();
    }
}
