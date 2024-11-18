using System.Security.Cryptography;

bool gameOn = true;
while (gameOn == true)
{
    Random rand = new Random();
    int rng = rand.Next(1, 101);
    int attempts = 0;

    Console.WriteLine("Guess a number between 1 and 100");


    bool asked = true;

    while (asked == true)
    {
        int userInput = Convert.ToInt32(Console.ReadLine());
        attempts++;

        if (userInput < rng)
        {
            Console.WriteLine("Too low");
        }
        else if (userInput > rng)
        {
            Console.WriteLine("Too high");
        }
        else
        {
            Console.WriteLine($"THATS RIGHT, {rng} WAS THE NUMBER! ");
            Console.WriteLine($"Number of guesses: {attempts}");
            Console.WriteLine("Do you want to play again? y/n");
            asked = false;
        }
    }

    string replay = Console.ReadLine();

    if (replay == "n")
    {
        Console.WriteLine("Ok, bye then ;.;");
        gameOn = false;
    }
}
