// See https://aka.ms/new-console-template for more information

using System;

// Console.WriteLine("Hello, World!");



namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the game board
            char[,] board = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }

            // Initialize the current player and the game status
            char player = 'X';
            bool gameOver = false;

            // Main game loop
            while (!gameOver)
            {
                // Display the game board
                Console.Clear();
                Console.WriteLine(" {0} | {1} | {2} ", board[0, 0], board[0, 1], board[0, 2]);
                Console.WriteLine("-----------");
                Console.WriteLine(" {0} | {1} | {2} ", board[1, 0], board[1, 1], board[1, 2]);
                Console.WriteLine("-----------");
                Console.WriteLine(" {0} | {1} | {2} ", board[2, 0], board[2, 1], board[2, 2]);

                // Get the player's move
                Console.WriteLine("Player {0}, enter your move (row column):", player);
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                // Make sure the move is valid
                if (row < 0 || row > 2 || col < 0 || col > 2 || board[row, col] != ' ')
                {
                    Console.WriteLine("Invalid move, try again!");
                    Console.ReadLine();
                    continue;
                }

                // Update the game board with the player's move
                board[row, col] = player;

                // Check for a win
                if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) ||
                    (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player) ||
                    (board[0, 0] == player && board[0, 1] == player && board[0, 2] == player) ||
                    (board[1, 0] == player && board[1, 1] == player && board[1, 2] == player) ||
                    (board[2, 0] == player && board[2, 1] == player && board[2, 2] == player) ||
                    (board[0, 0] == player && board[1, 0] == player && board[2, 0] == player) ||
                    (board[0, 1] == player && board[1, 1] == player && board[2, 1] == player) ||
                    (board[0, 2] == player && board[1, 2] == player && board[2, 2] == player))
                {
                    Console.WriteLine("Player {0} wins!", player);
                    gameOver = true;
                }

                // Check for a draw
                // Check for a draw
                bool draw = true;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == ' ')
                        {
                            draw = false;
                            break;
                        }
                    }
                }

                if (draw)
                {
                    Console.WriteLine("It's a draw!");
                    gameOver = true;
                }

                // Switch players
                if (player == 'X')
                {
                    player = 'O';
                }
                else
                {
                    player = 'X';
                }
            }

            Console.ReadLine();
        }
    }
}

