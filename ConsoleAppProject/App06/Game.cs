using System;
using System.Linq;
using ConsoleAppProject.App06;


class Game
{

    public void Play()
    {
        var userScore = 0;
        var computerScore = 0;
        bool keepPlaying = true;
        
        
        Console.WriteLine("What's your name?");
        string userChoiceName = Console.ReadLine();

        while (keepPlaying)
        {
            Console.WriteLine("How many rounds do you want to play?");
            Int32.TryParse(Console.ReadLine(), out int rounds);
            
            while (rounds != 0 )
            {
                Console.WriteLine("Do you choose rock,paper or scissors");
                string userChoice = Console.ReadLine();

                Random r = new Random();
                int computerChoice = r.Next(3);
                // rock = 0, paper = 1, scissors = 2
                var victory = 0;
                //player victory, draw = 0, loss = 1, win = 2


                switch (userChoice)
                {
                    case "rock":
                       // GameImages.DrawRock(0, 40);
                        switch (computerChoice)
                        {
                            case 0:
                                victory = 0;
                                break;
                            case 1:
                                victory = 1;
                                computerScore++;
                                break;
                            case 2:
                                victory = 2;
                                userScore++;
                                break;
                        }

                        break;
                    case "paper":
                        //GameImages.DrawPaper(0, 40);
                        switch (computerChoice)
                        {
                            case 0:
                                victory = 2;
                                userScore++;
                                break;
                            case 1:
                                victory = 0;
                                break;
                            case 2:
                                victory = 1;
                                computerScore++;
                                break;
                        }

                        break;
                    case "scissors":
                       // GameImages.DrawScissors(0, 40);
                        switch (computerChoice)
                        {
                            case 0:
                                victory = 1;
                                computerScore++;
                                break;
                            case 1:
                                victory = 2;
                                userScore++;
                                break;
                            case 2:
                                victory = 0;
                                break;
                        }

                        break;
                }

                switch (computerChoice)
                {
                    case 0:
                       // GameImages.DrawRock(60, 40);
                        Console.WriteLine("The computer chose Rock");
                        break;
                    case 1:
                       // GameImages.DrawPaper(60, 40);
                        Console.WriteLine("The computer chose Paper");
                        break;
                    case 2:
                      //  GameImages.DrawScissors(60, 40);
                        Console.WriteLine("The computer chose Scissors");
                        break;
                }

                switch (victory)
                {
                    case 0:
                        Console.WriteLine(userChoiceName+" drew!");
                        break;
                    case 1:
                        Console.WriteLine(userChoiceName+" lost, Too bad.");
                        break;
                    case 2:
                        Console.WriteLine(userChoiceName+" won, congratulations!");
                        break;
                }

                Console.WriteLine(userChoiceName+"'s score is : " + userScore);
                Console.WriteLine("Computer score is : " + computerScore);
                rounds--;
            }

            if (rounds == 0)
            {
                Console.WriteLine("New game? y/n");
                ConsoleKeyInfo cki = Console.ReadKey(); //wait for player to press a key
                keepPlaying = cki.KeyChar == 'y'; //continue only if y was pressed
                
            }
        }
        
    }
    
}