Console.WriteLine("Welcome to Rock Paper Scissor Game");
Console.WriteLine();
Console.WriteLine("Press 1 for Single Player Or 2 for Multiplyer");

int userModeChoice;
int computerChoice, userChoice;
char playAgain;
string userChoiceInStr, computerChoiceInStr;

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

        if(userChoice == 1)
        {
            Console.WriteLine($"Your choice: Rock");
        }else if(userChoice == 2)
        {
            Console.WriteLine($"Your choice: Paper");

        }else if(userChoice == 3)
        {
            Console.WriteLine($"Your choice: Scissor");

        }

        if(computerChoice == 1)
        {
            Console.WriteLine($"Computer's choice: Rock\n\n");
        }else if(computerChoice == 2)
        {
            Console.WriteLine($"Computer's choice: Paper\n\n");

        }else if(computerChoice == 3)
        {
            Console.WriteLine($"Computer's choice: Scissor\n\n");

        }

        // User win situation
        if(userChoice == computerChoice)
        {
            Console.WriteLine("It's a Draw!\n\n");
        }
        else if ((userChoice == 1 && computerChoice == 3) || (userChoice == 2 && computerChoice == 1) || (userChoice == 3 && computerChoice == 2))
        {
            Console.WriteLine("Contrazs! You Won!\n\n");
        }else
        {
            Console.WriteLine("Sorry You Lose!\n\n");
        }


        Console.WriteLine("Do you want to play again? (y)");
        if(!char.TryParse(Console.ReadLine(), out playAgain))
        {
            Console.WriteLine("Please press y to continue");
            return;
        }

        if(playAgain == 'y')
        {
            Console.Clear();
            continue;
        }
        else
        {
            Console.WriteLine("Byee... See you againg");
            break;
            
        }

        
    }

} else
{

}
