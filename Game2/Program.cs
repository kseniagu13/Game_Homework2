using System;

namespace Game2
{
    class Program
    {
        static void Main(string[] args)
        {


            int rolls = 0; //katsete arv
            int consoleChoice;
            string userChoice;
            int consoleScore = 0; //arvuti skoor
            int userScore = 0; // kasutaja skoor
            string firstName;
            string lastName;

            Console.WriteLine("Enter your first name, please: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name, please: ");
            lastName = Console.ReadLine();
            Console.WriteLine($"Hello {firstName} {lastName}!");
            Console.ReadLine();


            Random rnd = new Random(); //objekt, mis genereerib juhusliku numbri


            while (userScore < 3 && consoleScore < 3)  //mäng käib kuni 3 p kes esimesena saab
            {
                Console.WriteLine("Choose rock,paper or scissors: ");
                userChoice = Console.ReadLine();
                consoleChoice = rnd.Next(1, 4); //genereerib 1-3 stsenaariumi


                if (consoleChoice == 1) //rock
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("It is a tie");

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("You won,paper beats rock ");
                        userScore++;
                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("Sorry you lost,rock beats scissors");
                        consoleScore++;
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock,paper or scissors!");
                    }
                    
                }
                else if (consoleChoice == 2) // paper
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("Sorry you lost,paper beats rock");
                        consoleScore++;

                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("It is a tie");

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("You won,scissors beats paper");
                        userScore++;
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock,paper or scissors!");

                    }
                    

                }
                else // arvuti valib käärid
                {
                    if (userChoice == "rock")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("You won,rock beats scissors ");
                        userScore++;
                    }
                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("Sorry you lost,scissors beats paper");
                        consoleScore++;

                    }
                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("It is a tie ");
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock,paper or scissors!");

                    }
                    continue;
                }
                rolls++;
            }

            Console.ReadLine();

            if (userScore > consoleScore) // kui kasutaja sai rohkem punkte
            {
                Console.WriteLine("Congratulations! You won!");
            }
            else if (userScore < consoleScore) // kui kasutaja sai vähem punkte
            {
                Console.WriteLine("Oops, you lost. Try again!");
            }
            else
            {
                Console.WriteLine("Tie. Nobody wins or loses"); //viik, kuigi pole võimalik
            }
            Console.WriteLine($"You scored {userScore}, Computer scored {consoleScore}");
            Console.ReadLine();

        }
    }
}
