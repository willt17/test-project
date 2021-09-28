using System;

namespace test_project
{
    class Program
    {
        static void Main(string[] args)
        {
            mainMenu();
        }
        static void mainMenu()
        {
            Console.WriteLine( "Welcome to the MIS game zone" );
            Console.WriteLine( "press 1 for Pig." );
            Console.WriteLine( "press 2 for Blackjack dice" );
            Console.WriteLine( "press 3 to view the current high scores" );
            Console.WriteLine( "press 4 to exit the program" );
            string menuInput = Console.ReadLine();
            int menuSelection = Int32.Parse( menuInput );
            menuSwitch( menuSelection );
        }
        static void menuSwitch( int menuSelection )
        {
            switch (menuSelection)
            {
                case 1:
                    Console.WriteLine( "Pig" );
                    break;
                case 2:
                    Console.WriteLine( "Blackjack dice" );
                    break;
                case 3:
                    Console.WriteLine( "High score" );
                    break;
                case 4:
                    Console.WriteLine( "Exit" );
                    break;
                default :
                    Console.WriteLine( "This is an invalid command" );
                    break;
            }
        }
    }
}
