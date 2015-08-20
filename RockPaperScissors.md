using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        interface Iplayer
        {
            int NumOfWins { get; set; }
            string Act();
        }

        class Player1 : Iplayer
        {
            public int NumOfWins { get; set; }
            public string Act()
            {
                string act = "Rock";
                return act;
            }

            public Player1(int numOfWins)
            {
                this.NumOfWins = numOfWins;
            }
        }

        class Player2 : Iplayer
        {
            public int NumOfWins { get; set; }
            public string Act()
            {
                string act = "Paper";
                return act;
            }

            public Player2(int numOfWins)
            {
                this.NumOfWins = numOfWins;
            }
        }

        class Player3 : Iplayer
        {
            public int NumOfWins { get; set; }
            public string Act()
            {
                string act = "Scissor";
                return act;
            }

            public Player3(int numOfWins)
            {
                this.NumOfWins = numOfWins;
            }
        }

        class Game
        {
            public Iplayer Fight(Iplayer activePlayer1, Iplayer activePlayer2)
            {
                Iplayer winner;

                if (activePlayer1.Act() == "Rock" && activePlayer2.Act() == "Paper")
                {
                    winner = activePlayer2;
                    activePlayer2.NumOfWins += 1;
                }

                else if (activePlayer1.Act() == "Rock" && activePlayer2.Act() == "Scissor")
                {
                    winner = activePlayer1;
                    activePlayer1.NumOfWins += 1;
                }

                else if (activePlayer1.Act() == "Scissor" && activePlayer2.Act() == "Rock")
                {
                    winner = activePlayer2;
                    activePlayer2.NumOfWins += 1;
                }

                else if (activePlayer1.Act() == "Scissor" && activePlayer2.Act() == "Paper")
                {
                    winner = activePlayer1;
                    activePlayer1.NumOfWins += 1;
                }

                else if (activePlayer1.Act() == "Paper" && activePlayer2.Act() == "Scissor")
                {
                    winner = activePlayer2;
                    activePlayer2.NumOfWins += 1;

                }

                else
                {
                    winner = activePlayer1;
                    activePlayer1.NumOfWins += 1;
                }
              
                
                return winner;
            }

        }

        static void Main(string[] args)
        {
            var john = new Player1(0);
            var dana = new Player2(0);
            var josie = new Player3(0);
            var theGame = new Game(); 

            for(int i = 0; i < 100; i++)
            {
                var rnd = new Random();
                int value = rnd.Next(7);

                switch (value)
                {
                    case 1:
                        Console.WriteLine("Round " + i + " " + john.Act() + " VS " + dana.Act() + "  -----> WINNER: " + (theGame.Fight(john, dana)).Act());              
                        break;
                    case 2:
                        Console.WriteLine("Round " + i + " " + john.Act() + " VS " + josie.Act() + "  -----> WINNER: " + (theGame.Fight(john, josie)).Act());
                        break;
                    default:
                        Console.WriteLine("Round " + i + " " + dana.Act() + " VS " + josie.Act() + "  -----> WINNER: " + (theGame.Fight(dana, josie)).Act());
                        break;
                }
                
            }

            Console.WriteLine("Rock Number of Wins = " + john.NumOfWins);
            int rockWins = john.NumOfWins;
            Console.WriteLine("Paper Number of Wins = " + dana.NumOfWins);
            int paperWins = dana.NumOfWins;
            Console.WriteLine("Scissors Number of Wins = " + josie.NumOfWins);
            int scissorsWins = josie.NumOfWins;

            if(rockWins > paperWins && rockWins > scissorsWins)
            {
                Console.WriteLine("Rock Wins with total of: " + john.NumOfWins);
            }
            else if (paperWins > rockWins && paperWins > scissorsWins)
            {
                Console.WriteLine("Paper Wins with total of: " + dana.NumOfWins);
            }
            else  
            {
                Console.WriteLine("Scissors Wins with total of: " + josie.NumOfWins);
            }

            Console.Read();

        }

    }

}







