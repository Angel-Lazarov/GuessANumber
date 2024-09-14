Random randomNumber = new Random();
int computerNumber = randomNumber.Next(1,101);
Console.WriteLine($" /tGuess A Number");
while (true)
{
    Console.Write("Guess a number (1-100): ");
    bool isValid = int.TryParse(Console.ReadLine(), out int playerNumber);
    if (isValid)
    {
        if (playerNumber > computerNumber)
        {
            Console.WriteLine("Too High!");
        }
        else if (playerNumber < computerNumber)
        {
            Console.WriteLine("Too Low!");
        }
        else
        {
            Console.WriteLine("You guessed it!");
            break;
        }
    }
    else { Console.WriteLine("Invalid input! Try again."); }
}
