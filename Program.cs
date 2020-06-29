using System;

namespace c_homework_tictactoe_shailza85
{
    class Program
   {
        public static char [] BoardArray = {'1','2','3','4','5','6','7','8','9'}; // This aaray will store the player's input numbers.
        
        public static char playerToken = ' '; // Player's token will be 'X' or 'O'.
         static int playTurn = 0; // It will count each player  turns. If the value reaches 10 the game will be a draw.
         
         public static void resetGame()   //This method will reset the game board.
        {

            char [] BoardArrayInit = {'1','2','3','4','5','6','7','8','9'}; //Array to initialize the board again. 
            
            BoardArray = BoardArrayInit;
            GameBoard();
            playTurn = 0;

        }
         // Introduction and game rules for the player.
         static void Introduction()
        {
            Console.WriteLine("Welcome to TIC TAC TOE!!!");
            Console.WriteLine("Please press any key to begin!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n GAME RULES:");
            Console.WriteLine("\n There will be two players: Player 1 = X and Player 2 = O.");
            Console.WriteLine("\n Players take turns placing tokens into a square on a 3x3 board.");
            Console.WriteLine("\n Player 1 will start first.");  
            Console.WriteLine("\n Game Win and draw:" + "\n 1. The game is over when a line of three tokens is formed, or the board is full." + 
                                                        "\n 2. If a line of three is formed, the winner is the player whose tokens form that line." +
                                                        "\n 3. If the board is full and no line is formed, the game is a draw.");   
            
            Console.WriteLine("\n Please press any key to begin the game!");
            Console.ReadKey();
            Console.Clear();
        }
        static void GameBoard()  //Game Board design that will be shown on screen after game rules when user will press enter key .
        {
            Console.Clear();
            Console.WriteLine("Player 1= X and Player 2= O.");
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

             int player = 2, playerInput =0;
             bool inputStatus = true;

            Introduction();
         
            do    // @link https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do
            {
                                
                if(player == 2) // This condition will check player's position. 
                // @link https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else

                {
                   player = 1;
                   TokenXorO(player,playerInput);
                }

                else if(player == 1)
                {
                    player = 2;
                    TokenXorO(player,playerInput);

                }                    
                    GameBoard();
                    playTurn++;

                // The below 3 functions will check if the user wins.
                    WinHorizontal();
                    WinVertical();
                    WinDiagonal();

                if(playTurn == 10)  
                {

                  playDraw();
                }

                do   
                {
                    Console.WriteLine("Ready to play Player {0}: Its your chance to play.", player);

                    try  // @link https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch
                    {
                            playerInput = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                            Console.WriteLine("Please enter a number to continue.");
                    }

                    if ((playerInput == 1) && (BoardArray[0] == '1'))
                    {
                            inputStatus = true;
                    }
                    else if ((playerInput == 2) && (BoardArray[1] == '2'))
                    {
                            inputStatus = true;
                    }
                    else if ((playerInput == 3) && (BoardArray[2] == '3'))
                    {
                            inputStatus = true;
                    }
                    else if ((playerInput == 4) && (BoardArray[3] == '4'))
                    {   
                            inputStatus = true; 
                    }
                    else if ((playerInput == 5) && (BoardArray[4] == '5'))
                    {
                            inputStatus = true;
                    }
                    else if ((playerInput == 6) && (BoardArray[5] == '6'))
                    {
                            inputStatus = true;
                    }  
                    else if ((playerInput == 7) && (BoardArray[6] == '7'))
                    {                     
                            inputStatus = true;
                    }
                    else if ((playerInput == 8) && (BoardArray[7] == '8'))
                    {
                            inputStatus = true;
                    }
                    else if ((playerInput == 9) && (BoardArray[8] == '9'))
                    {
                           inputStatus = true;
                    }
                    else
                    { 
                            Console.WriteLine ("Please enter a square number to place your token. This square is already occupied. Please try again.");
                            inputStatus = false;
                    
                    }

                } while (!inputStatus);

            } while (true);
            // The loop plays each players turns and checks user's input on the board.
        
        } // Main method ends.

        public static void TokenXorO(int player, int playerInput)
        {
            if(player == 1)
            {
                playerToken = 'X';
            }

            else if(player == 2)
            {
                playerToken = 'O';
            }

                // Switch statement will check player's input as player token X or O.
            // @link https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch

            switch (playerInput)  
            {
                case 1:  
                BoardArray [0] = playerToken;
                break;

                case 2:  
                BoardArray [1] = playerToken;
                break;

                case 3:  
                BoardArray [2] = playerToken;
                break;

                case 4:  
                BoardArray [3] = playerToken;
                break;

                case 5:  
                BoardArray [4] = playerToken;
                break;

                case 6:  
                BoardArray [5] = playerToken;
                break;

                case 7:  
                BoardArray [6] = playerToken;
                break;

                case 8:  
                BoardArray [7] = playerToken;
                break;

                case 9:  
                BoardArray [8] = playerToken;
                break;
            }
        }

        public static void WinHorizontal()  // This methods will check if the player has win horizontally.
        {
            char[] playerTokens = {'X','O'};

            foreach (char playertoken in playerTokens)
            {
                if(((BoardArray[0] == playerToken) && (BoardArray[1] == playerToken)) && (BoardArray[2] == playerToken) ||
                  ((BoardArray[3] == playerToken) && (BoardArray[4] == playerToken)) && (BoardArray[5] == playerToken) ||
                  ((BoardArray[6] == playerToken) && (BoardArray[7] == playerToken)) && (BoardArray[8] == playerToken) )
                 
                {
                    Console.Clear();

                    if(playerToken == 'X')
                    {
                        Console.WriteLine("Yay congratulations!!! You are the winner, Player 1. You have played horizontally. Would you like to play again? Please press Y or N.");
                    }

                    else if(playerToken == 'O')
                    {
                        Console.WriteLine("Yay congratulations!!! You are the winner, Player 2. You have played horizontally. Would you like to play again? Please press Y or N.");
                    }
                    chkYorN();
                   // Console.WriteLine("Press any key to reset the game board!!");
                    //Console.ReadKey();
                    resetGame();
                    break;
                }
            }
        }


        public static void WinVertical()  // This methods will check if the player has win vertically.
        {
            char[] playerTokens = {'X','O'};

            foreach (char playertoken in playerTokens)
            {
                if(((BoardArray[0] == playerToken) && (BoardArray[3] == playerToken)) && (BoardArray[6] == playerToken) ||
                  ((BoardArray[1] == playerToken) && (BoardArray[4] == playerToken)) && (BoardArray[7] == playerToken) ||
                  ((BoardArray[2] == playerToken) && (BoardArray[5] == playerToken)) && (BoardArray[8] == playerToken) )
                 
                {
                    Console.Clear();

                    if(playerToken == 'X')
                    {
                        Console.WriteLine("Yay congratulations!!! You are the winner, Player 1. You have played vertically. Would you like to play again? Please press Y or N.");
                    }

                    else
                    {
                        Console.WriteLine("Yay congratulations!!! You are the winner, Player 2. You have played vertically. Would you like to play again? Please press Y or N.");
                    }
                    chkYorN();
                    //Console.WriteLine("Press any key to reset the game board!!");
                    //Console.ReadKey();
                    resetGame();

                    break;
                }
            }
        }

        public static void WinDiagonal()  // This methods will check if the player has win diagonally.
        {
            char[] playerTokens = {'X','O'};

            foreach (char playertoken in playerTokens)
            {
                if(((BoardArray[0] == playerToken) && (BoardArray[4] == playerToken)) && (BoardArray[8] == playerToken) ||
                  ((BoardArray[6] == playerToken) && (BoardArray[4] == playerToken)) && (BoardArray[2] == playerToken) )
                 
                {
                    //Console.Clear();

                    if(playerToken == 'X')
                    {
                        Console.WriteLine("Yay congratulations!!! You win the game diagonally, Player 1.Would you like to play again? Please press Y or N.");
                    }

                    else
                    {
                        Console.WriteLine("Yay congratulations!!! You win the game diagonally, Player 2. Would you like to play again? Please press Y or N.");
                    }
                        chkYorN();
                    //Console.WriteLine("Press any key to reset the game board!!");
                    //Console.ReadKey();
                    resetGame();
                    break;
                }
            } 
        }

        public static void playDraw()  //playDraw method will prompt the user to play again as game is a draw.
        {         
            Console.WriteLine("The game is a Draw. Would you like to play again? Please press Y or N.");
            //Console.ReadKey(); 
            chkYorN();
            resetGame();        
        }

        public static void chkYorN()
        {
            char inputValue = '0';
            bool inputError = true;

            while (inputError == true)
            {
                inputValue = Console.ReadKey().KeyChar;
                inputValue = inputValue.ToString().ToUpper().ToCharArray()[0];

                if (inputValue == 'Y')
                {
                    inputError = false;
                }

                else if (inputValue == 'N')
                {
                     inputError = false;
                     Console.WriteLine("Thank you for playing the game. Enjoy your rest of the day!!!");
                }

            else
            {
                inputError = true;
                Console.WriteLine("You have entered invalid character. please try again.");
            }
            }

        }
    }

}