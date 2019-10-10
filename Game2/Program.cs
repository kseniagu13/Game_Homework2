using System;

namespace Game2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int consoleChoice;
            string userChoice;
            int consoleScore = 0; //arvuti skoor
            int userScore = 0; // kasutaja skoor
            string fullName;
            bool gameOver = false;
           

            Console.WriteLine("Enter your full name, please: ");
            fullName = Console.ReadLine();
            
            Console.WriteLine($"Nice to meet you {fullName} !");
            Console.ReadLine();





            while (!gameOver)  //mäng käib kuni 3 p kes esimesena saab; kuni mäng lõpeb
            {
                Console.WriteLine("Choose rock,paper or scissors: ");
                userChoice = Console.ReadLine();
                Random rnd = new Random(); //objekt, mis genereerib juhusliku numbri
                consoleChoice = rnd.Next(1, 4); //genereerib 1-3 stsenaariumi


                if (consoleChoice == 1) //rock
                {
                    if (userChoice.ToLower() == "rock")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("It is a tie");
                        Console.WriteLine($"{fullName} score is {userScore} and Computer score is {consoleScore}");


                    }
                    else if (userChoice.ToLower() == "paper")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("You won,paper beats rock ");
                        userScore++;
                        Console.WriteLine($"{fullName} score is {userScore} and Computer score is {consoleScore}");
                    }
                    else if (userChoice.ToLower() == "scissors")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("Sorry you lost,rock beats scissors");
                        consoleScore++;
                        Console.WriteLine($"{fullName} score is {userScore} and Computer score is {consoleScore}");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock,paper or scissors!");
                        
                    }

                }
                else if (consoleChoice == 2) // paper
                {
                    if (userChoice.ToLower() == "rock")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("Sorry you lost,paper beats rock");
                        consoleScore++;
                        Console.WriteLine($"{fullName} score is {userScore} and Computer score is {consoleScore}");

                    }
                    else if (userChoice.ToLower() == "paper")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("It is a tie");
                        Console.WriteLine($"{fullName} score is {userScore} and Computer score is {consoleScore}");

                    }
                    else if (userChoice.ToLower() == "scissors")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("You won,scissors beats paper");
                        userScore++;
                        Console.WriteLine($"{fullName} score is {userScore} and Computer score is {consoleScore}");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock,paper or scissors!");
                        
                    }


                }
                else // arvuti valib käärid
                {
                    if (userChoice.ToLower() == "rock")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("You won,rock beats scissors ");
                        userScore++;
                        Console.WriteLine($"{fullName} score is {userScore} and Computer score is {consoleScore}");
                    }
                    else if (userChoice.ToLower() == "paper")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("Sorry you lost,scissors beats paper");
                        consoleScore++;
                        Console.WriteLine($"{fullName} score is {userScore} and Computer score is {consoleScore}");

                    }
                    else if (userChoice.ToLower() == "scissors")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("It is a tie ");
                        Console.WriteLine($"{fullName} score is {userScore} and Computer score is {consoleScore}");

                    }
                    else
                    {
                        Console.WriteLine("You must choose rock,paper or scissors!");
                        
                    }

                    
                }




              

                if (userScore == 3) // kui kasutaja sai 3 punkti
                {
                    Console.WriteLine($"Congratulations! You won! You scored {userScore}, Computer scored {consoleScore}");
                    gameOver = true;

                }
                else if (consoleScore == 3) // kui arvuti sai 3 punkti
                {
                    Console.WriteLine($"Oops, you lost. Try again! You scored {userScore}, Computer scored {consoleScore}");
                    gameOver = true;
                }
                else
                {
                  
                    continue;
                }
               

            }
            

                Console.ReadLine();
            
        }
    }
}


