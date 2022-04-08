// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public static void Main(string[] args)
{
    Console.WriteLine("Welcome to HiLo.");
    Console.WriteLine($"Guess numbers between 1 and {HiLoGame.MAXIMUM}.");
    HiLoGame.Hint();
    while (HiLoGame.GetPot() > 0)
    {
        Console.WriteLine("Press h for higher, l for lower, ? to buy a hint,");
        Console.WriteLine($"or any other key to quit with {HiLoGame.GetPot()}.");
        char key = Console.ReadKey(true).KeyChar;
        if (key == ’h’) HiLoGame.Guess(true);
            else if (key == ’l’) HiLoGame.Guess(false);
            else if (key == ’?’) HiLoGame.Hint();
            else return;
        }
        Console.WriteLine("The pot is empty. Bye!");

    }
static class HiloGame
{
    private static Random r = new Random();
    public const int MAXIMUM = 10;
    private static int currentNumber = Random.Next(1, MAXIMUM+1);
    private  static int pot = 10;

}
public static void Guess()
{
    bool higher;

}