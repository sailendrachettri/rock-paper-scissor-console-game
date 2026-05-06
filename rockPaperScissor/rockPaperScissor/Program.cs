Console.WriteLine("Welcome to Rock Paper Scissor Game");
Console.WriteLine();
Console.WriteLine("Press 1 for Single Player Or 2 for Multiplyer");

int userModeChoice;
int computerChoice, userChoice;
int[] allowIfOne = { 2, 3 };
int[] allowIfTwo = { 1, 3 };
int[] allowIfThree = { 1, 2 };

Random rand = new Random();

if (!int.TryParse(Console.ReadLine(), out userModeChoice))
{
    Console.WriteLine("Please Select a valid option");
    return;
}

if(userModeChoice == 1)
{
    int rock = 1, paper = 2, scissor = 3;


    while (true)
    {
        Console.WriteLine("Your turn : 1 for Rock, 2 for Paper and 3 for Scissor");
        if(!int.TryParse(Console.ReadLine(), out userChoice))
        {
            Console.WriteLine("Please select a valid option");
        }

        
        

        if(userChoice == 1)
        {
            computerChoice = allowIfOne[rand.Next(allowIfOne.Length)];
        }else if(userChoice == 2)
        {
            computerChoice = allowIfTwo[rand.Next(allowIfTwo.Length)];
        }else if(userChoice == 3)
        {
            computerChoice = allowIfThree[rand.Next(allowIfThree.Length)];
        }
        else
        {
            computerChoice = userChoice;
        }

        Console.WriteLine($"Your choice: {userChoice}");
        Console.WriteLine($"Computer choice: {computerChoice}");

        Console.WriteLine("");
        Console.WriteLine("");

        // User win situation
        if ((userChoice == 1 && computerChoice == 3) || (userChoice == 2 && computerChoice == 1) || (userChoice == 3 && computerChoice == 2))
        {
            Console.WriteLine("You Won!");
        }else
        {
            Console.WriteLine("You Lose!");
        }

        Console.WriteLine("");
        Console.WriteLine("");
    }

} else
{

}
