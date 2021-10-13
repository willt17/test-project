using System;

namespace test_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int gil = 100;
            while ( gil > 0 && gil < 300 )
            {
                  mainMenu( ref gil );
            }
            gilCheck( ref gil );
            
        }
        static void mainMenu( ref int gil )
        {
            Console.WriteLine( "Welcome to the MIS game zone" );
            Console.WriteLine( "press 1 for Pig." );
            Console.WriteLine( "press 2 for Blackjack dice" );
            Console.WriteLine( "press 3 to view the current high scores" );
            Console.WriteLine( "press 4 to exit the program" );
            string menuInput = Console.ReadLine();
            int menuSelection = Int32.Parse( menuInput );
            menuSwitch( menuSelection, ref gil );
        }
        static void menuSwitch( int menuSelection, ref int gil )
        {
            switch (menuSelection)
            {
                case 1:
                    Console.WriteLine( "Pig" );
                    pigMethod();
                    break;
                case 2:
                    blackjackFunction();
                    break;
                case 3:
                    Console.WriteLine( "High score" );
                    break;
                case 4:
                    exitScreen();
                    break;
                default :
                    Console.WriteLine( "This is an invalid command" );
                    break;
            }
        }
        static void exitScreen()
        {
            Console.WriteLine( "Thanks for using our application" );
            Environment.Exit( 0 );
        }
        static void pigGame( ref int gil )
        {
            Console.WriteLine( "Welcome to pig" );
            Console.WriteLine( gil );
            gil = gil + 20;
        }
        static void winnerScreen()
        {
            Console.WriteLine( "A winner is you" );
            exitScreen();
        }
        static void loserScreen()
        {
            Console.WriteLine( "You are out of Gil." );
            exitScreen();
        }
        static void blackjackGame( ref int gil )
        {
            Console.WriteLine( "Welcome to blackjack" );
            Console.WriteLine( gil );
            gil = gil - 20;
        }
        static void gilCheck( ref int gil )
        {
            if ( gil >= 300 )
            {
                winnerScreen();
            }
            else
            {
                loserScreen();
            }
        }
        static void pigMethod()
        {
            int player1Score = 0;
            int player2Score = 0;
            Console.WriteLine("Welcome to Pig");
            Console.WriteLine( "test1" );
            pigPlayer1( ref player1Score, ref player2Score );
        }
        static int random1()
        {
            Random randomNumber= new Random();
            int number;
            number = randomNumber.Next( 1, 10 );
            return number;
        }
        static void pigPlayer1( ref int player1Score, ref int  player2Score )
        {
            Console.WriteLine( "Player 1 is rolling" );
            while ( player1Score < 100 )
            {
                 int addScore = random1();
                 if ( addScore != 1 )
                 {
                     player1Score = addScore + player1Score;
                     Console.WriteLine( player1Score );
                 }
                 else
                 {
                     Console.WriteLine( "Your turn has ended" );
                     player2Method( ref player2Score, ref player1Score );
                     break;
                 }
                 
            }
        }
        static void player2Method( ref int player2Score, ref int player1Score )
        {
            Console.WriteLine( "It is player 2's turn" );
            pigPlayer2( ref player2Score, ref player1Score);
        }
        static void pigPlayer2( ref int player2Score, ref int player1Score)
        {
            Console.WriteLine( "Player 2 is rolling" );
            while ( player2Score < 100 )
            {
                 int addScore = random1();
                 if ( addScore != 1 )
                 {
                     player2Score = addScore + player2Score;
                     Console.WriteLine( player2Score );
                 }
                 else
                 {
                     Console.WriteLine( "Your turn has ended" );
                     Console.WriteLine( "It is back to player 1" );
                     pigPlayer1( ref player1Score, ref player2Score );
                     break;
                 }
                 
            }
        }
        static void blackjackFunction()
        {
            Console.WriteLine( "Time to play blackjack" );
            blackjackGame();
        }
        static int random2()
        {
            Random randomNumber= new Random();
            int number;
            number = randomNumber.Next( 1, 10 );
            return number;
        }
        static void blackjackGame()
        {
            int player1Cards = 0;
            int player2Cards = 0;
            if ( player1Cards < 21 && player2Cards < 21 )
            {
                bjPlayerTurnInit( ref player1Cards );
                bjComputerTurnInit( ref player2Cards );
                Console.WriteLine( "You have " + player1Cards );
                Console.WriteLine( "The computer has " + player2Cards );
                playerDecision( ref player1Cards, ref player2Cards );
            }
        }
        static void bjPlayerTurnInit( ref int player1Cards )
        {
            int pCard1 = random2();
            int pCard2 = random2();
            player1Cards  = pCard1 + pCard2;  
        }
        static void bjComputerTurnInit( ref int player2Cards )
        {
            int cCard1 = random2();
            int cCard2 = random2();
            player2Cards = cCard1 + cCard2; 
        }
        static void playerDecision( ref int player1Cards, ref int player2Cards )
        {
            Console.WriteLine( "Press 1 to stand or 2 to hit" );
            string input = Console.ReadLine();
            int userInput = int.Parse( input );
            switch ( userInput )
            {
                case 1:
                    standFunction( ref player1Cards, ref player2Cards );
                    break;
                case 2:
                    hitFunction( ref player1Cards, ref player2Cards );
                    break;
                default:
                    wrongInput();
                    break;
            }
        }
        static void standFunction( ref int player1Cards, ref int player2Cards )
        {
            Console.WriteLine( "You chose to stand" );
            Console.WriteLine( "You still have " + player1Cards );
            computerLogic( ref player2Cards, ref player1Cards );
        }
        static void hitFunction( ref int player1Cards, ref int player2Cards )
        {
            Console.WriteLine( "You chose to hit" );
            int pAdd = random2();
            player1Cards = player1Cards + pAdd;
            Console.WriteLine( "You now have " + player1Cards );
            if ( player1Cards < 21 )
            {
                computerLogic( ref player2Cards, ref player1Cards );
            }
            else if ( player1Cards == 21 )
            {
                bjWin();
            }
            else
            {
                bjLose();
            }
        }
        static void wrongInput()
        {
            Console.WriteLine( "That input is not valid" );
        }
        static void computerLogic( ref int player2Cards, ref int player1Cards )
        {
            if ( player2Cards < 17 )
            {
                computerHit( ref player2Cards, ref player1Cards );
            }
            else
            {
                computerStand( ref player2Cards, ref player1Cards );
            }
        }
        static void computerHit( ref int player2Cards, ref int player1Cards )
        {
            Console.WriteLine( "The computer will hit" );
            int cAdd = random2();
            player2Cards = player2Cards + cAdd;
            Console.WriteLine( "The computer now has " + player2Cards );
            playerDecision( ref player1Cards, ref player2Cards );
        }
        static void computerStand( ref int player2Cards, ref int player1Cards )
        {
            Console.WriteLine( "The computer will stand at " + player2Cards );
            Console.WriteLine( "Press 1 to stand or 2 to hit" );
            string input = Console.ReadLine();
            int userInput = int.Parse( input );
            switch ( userInput )
            {
                case 1:
                    handCheck(ref player1Cards, ref player2Cards );
                    break;
                case 2:
                    hitFunction( ref player1Cards, ref player2Cards );
                    handCheck( ref player1Cards, ref player2Cards );
                    break;
                default:
                    wrongInput();
                    break;
            }
        }
        static void bjWin()
        {
            Console.WriteLine( "You won this hand" );
        }
        static void bjLose()
        {
            Console.WriteLine( "You lost this hand" );
        }
        static void handCheck(ref int player1Cards, ref int player2Cards )
        {
            if ( player1Cards > player2Cards )
            {
                bjWin();
            }
            else
            {
                bjLose();
            } 
        }   
    }
}
