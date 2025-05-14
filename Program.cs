using System;

class CarrotInABoxGame
{
    static Random random = new Random();

    static void Main()
    {
        Console.WriteLine("Carrot in a Box");

        Console.Write("Human player 1, enter your name: ");
        string player1Name = Console.ReadLine();
        Console.Write("Human player 2, enter your name: ");
        string player2Name = Console.ReadLine();

        bool playAgain;

        do
        {
            Console.Clear();
            ShowBoxes(player1Name, player2Name);

            bool carrotInRedBox = random.Next(2) == 0;

            Console.WriteLine($"\n{player1Name}, you have a RED box in front of you.");
            Console.WriteLine($"{player2Name}, you have a GOLD box in front of you.");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.WriteLine($"\nWhen {player2Name} has closed their eyes, press Enter...");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"{player1Name}, here is the inside of your box:");
            ShowBoxContents(carrotInRedBox, player1Name, player2Name);

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"{player2Name}, it's your turn to guess which box contains the carrot.");
            Console.WriteLine("Type 'Red' or 'Gold' to guess:");
            string player2Guess = Console.ReadLine().Trim().ToLower();

            while (player2Guess != "red" && player2Guess != "gold")
            {
                Console.WriteLine("Invalid input. Please type 'Red' or 'Gold' to guess:");
                player2Guess = Console.ReadLine().Trim().ToLower();
            }

            bool isGuessCorrect = (player2Guess == "red" && carrotInRedBox) || (player2Guess == "gold" && !carrotInRedBox);

            Console.WriteLine($"\nThe carrot was in the {(carrotInRedBox ? "Red" : "Gold")} box.");

            if (isGuessCorrect)
            {
                Console.WriteLine($"{player2Name} guessed correctly!");
            }
            else
            {
                Console.WriteLine($"Oops! {player2Name} guessed wrong.");
            }

            Console.Write("\nDo you want to play again? (yes/no): ");
            string answer = Console.ReadLine().Trim().ToLower();
            playAgain = (answer == "yes" || answer == "y");

        } while (playAgain);

        Console.WriteLine("\nThanks for playing! Goodbye!");
    }

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

    static void ShowBoxContents(bool carrotInRedBox, string player1Name, string player2Name)
    {

        if (carrotInRedBox)
        {
            Console.WriteLine("   ___VV____       __________");
            Console.WriteLine("  |   VV    |     /         /|");
            Console.WriteLine("  |   VV    |    +---------+ |");
            Console.WriteLine("  |___||____|    |         | |");
            Console.WriteLine(" /    ||   /|    |   GOLD  | |");
            Console.WriteLine("+---------+ |    |   BOX   | /");
            Console.WriteLine("|   RED   | |    +---------+/ ");
            Console.WriteLine("|   BOX   | /");
            Console.WriteLine("+---------+/");
        }
        else

        {
            Console.WriteLine("  __________        ___VV____");
            Console.WriteLine(" /         /|      |   VV    |");
            Console.WriteLine("+---------+ |      |   VV    |");
            Console.WriteLine("|         | |      |___||____|");
            Console.WriteLine("|   RED   | |     /    ||   /|");
            Console.WriteLine("|   BOX   | /    +---------+ |");
            Console.WriteLine("+---------+/     |   GOLD  | |");
            Console.WriteLine("                |   BOX   | /");
            Console.WriteLine("                +---------+/ ");
        }

        Console.WriteLine($"   {player1Name}           {player2Name}");
    }
}
