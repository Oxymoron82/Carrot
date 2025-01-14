// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");






// Game Title
Console.WriteLine("Carrot in a Box, by Al Sweigart\n");

// Input player names
Console.Write("Human player 1, enter your name: ");
string player1Name = Console.ReadLine();
Console.Write("Human player 2, enter your name: ");
string player2Name = Console.ReadLine();

// Show box options
ShowBoxes(player1Name, player2Name);

// Randomly choose which box contains the carrot
Random random = new Random();
bool carrotInRedBox = random.Next(2) == 0; // Red box has the carrot 50% of the time

// Let players know which box is which
Console.WriteLine($"\n{player1Name}, you have a RED box in front of you.");
Console.WriteLine($"{player2Name}, you have a GOLD box in front of you.");
Console.WriteLine("Press Enter to continue...");
Console.ReadLine();

// Alice knows the carrot's position, Bob closes his eyes
Console.WriteLine($"\nWhen {player2Name} has closed their eyes, press Enter...");
Console.ReadLine();

// Alice (player 1) gets to see the inside of the red box
Console.WriteLine($"{player1Name}, here is the inside of your box:");
ShowBoxContents(carrotInRedBox, player1Name, player2Name);

// Wait for user input to continue
Console.WriteLine("Press Enter to continue...");
Console.ReadLine();

// Bob (player 2) guesses which box has the carrot
Console.WriteLine($"{player2Name}, it's your turn to guess which box contains the carrot.");
Console.WriteLine("Type 'Red' or 'Gold' to guess:");
string player2Guess = Console.ReadLine().Trim().ToLower();

// Check if Bob guessed correctly
bool isGuessCorrect = (player2Guess == "red" && carrotInRedBox) || (player2Guess == "gold" && !carrotInRedBox);

if (isGuessCorrect)
{
    Console.WriteLine($"\n{player2Name} guessed correctly! The carrot was in the {(carrotInRedBox ? "Red" : "Gold")} box!");
}
else
{
    Console.WriteLine($"\nOops! {player2Name} guessed wrong. The carrot was in the {(carrotInRedBox ? "Red" : "Gold")} box.");
}

// End game
Console.WriteLine("Thank you for playing!");


// Function to show the box details
static void ShowBoxes(string player1Name, string player2Name)
{
    Console.WriteLine("\nHERE ARE TWO BOXES:");
    Console.WriteLine("  __________     __________");
    Console.WriteLine(" /         /|   /         /|");
    Console.WriteLine("+---------+ |  +---------+ |");
    Console.WriteLine("|   RED   | |  |   GOLD  | |");
    Console.WriteLine("|   BOX   | /  |   BOX   | /");
    Console.WriteLine("+---------+/   +---------+/ ");
    Console.WriteLine($"   {player1Name}           {player2Name}");
    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
}

// Function to show the box contents (whether the carrot is in it or not)
static void ShowBoxContents(bool carrotInRedBox, string player1Name, string player2Name)
{
    Console.WriteLine("   ___VV____");
    Console.WriteLine("  |   VV    |");
    Console.WriteLine("  |   VV    |");
    Console.WriteLine("  |___||____|    __________");
    Console.WriteLine(" /    ||   /|   /         /|");
    Console.WriteLine("+---------+ |  +---------+ |");
    Console.WriteLine("|   RED   | |  |   GOLD  | |");
    Console.WriteLine("|   BOX   | /  |   BOX   | /");
    Console.WriteLine("+---------+/   +---------+/ ");

    // Show if carrot is in the red box
    if (carrotInRedBox)
    {
        Console.WriteLine(" (carrot!)");
    }
    else
    {
        Console.WriteLine(" (empty)");
    }

    Console.WriteLine($"   {player1Name}           {player2Name}");
}

