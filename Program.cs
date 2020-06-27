using System;

namespace c_homework_tictactoe_shailza85
{
    class Program
   {
        
        int player1, player2;
            static char [] BoardArray = {'1','2','3','4','5','6','7','8','9'};
         //Introduction and game rules for the player.
         static void Introduction()
        {
          Console.WriteLine("Welcome to TIC TAC TOE!!!");
            Console.WriteLine("Please press enter key to begin!");
            string v = Console.ReadLine();
            Console.WriteLine("\b GAME RULES");
            Console.WriteLine("\n There will be two players: Player 1 and Player 2");
            Console.WriteLine("\n Players take turns placing tokens into a square on a 3x3 board.");
            Console.WriteLine("\n Player 1 will start first.");  
            Console.WriteLine("\n Game Win and draw:" + "\n 1. The game is over when a line of three tokens is formed, or the board is full." + 
                                                        "\n 2. If a line of three is formed, the winner is the player whose tokens form that line." +
                                                        "\n 3. If the board is full and no line is formed, the game is a draw.");   
            
            Console.WriteLine("\n Please press enter key to begin the game!\n");
            Console.ReadLine();

            GameBoardArr();
            }
            static void GameBoardArr()  //Game Board design.
            {

            Console.WriteLine("---------------------");
            Console.WriteLine("|     |      |      |");
            Console.WriteLine("|  {0}  |  {1}   |  {2}   | ", BoardArray[0], BoardArray[1], BoardArray[2]);
            Console.WriteLine("|     |      |      |");
            Console.WriteLine("---------------------");
            Console.WriteLine("|     |      |      |");
            Console.WriteLine("|  {0}  |  {1}   |  {2}   | ", BoardArray[3], BoardArray[4], BoardArray[5]);
            Console.WriteLine("|     |      |      |");
            Console.WriteLine("---------------------");
            Console.WriteLine("|     |      |      |");
            Console.WriteLine("|  {0}  |  {1}   |  {2}   | ", BoardArray[6], BoardArray[7], BoardArray[8]);
            Console.WriteLine("|     |      |      |");
            Console.WriteLine("---------------------");

            }
 
        static void Main(string[] args)
        {
        
            Introduction();

    }
} }


