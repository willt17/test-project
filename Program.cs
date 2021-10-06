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
                    pigGame( ref gil );
                    break;
                case 2:
                    blackjackGame( ref gil );
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
    }
}
