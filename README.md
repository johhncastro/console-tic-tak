
Tic Tac Toe in C#
This tutorial will show you how to create a simple Tic Tac Toe game in C# using a console application.

Prerequisites
Visual Studio
Step 1: Create a new console application
Open Visual Studio and create a new console application project.

Step 2: Declare the game board
Declare a two-dimensional array of characters to represent the game board, and initialize it to all empty spaces:

Copy code
char[,] board = new char[3, 3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        board[i, j] = ' ';
    }
}
Step 3: Declare the game variables
Declare a character variable to represent the current player (X or O) and a boolean variable to represent the game's over status. Initialize the current player to X and the game over status to false:

Copy code
char player = 'X';
bool gameOver = false;
Step 4: Create the main game loop
Create a main game loop that runs until the game is over:

Copy code
while (!gameOver)
{
    // Main game logic goes here
}
Step 5: Display the game board
Inside the main game loop, display the game board to the console:

Copy code
Console.Clear();
Console.WriteLine(" {0} | {1} | {2} ", board[0, 0], board[0, 1], board[0, 2]);
Console.WriteLine("-----------");
Console.WriteLine(" {0} | {1} | {2} ", board[1, 0], board[1, 1], board[1, 2]);
Console.WriteLine("-----------");
 Console.WriteLine(" {0} | {1} | {2} ", board[2, 0], board[2, 1], board[2, 2]);
Step 6: Get the player's move
Prompt the player to enter their move (row and column), and read the player's input:

Copy code
Console.WriteLine("Player {0}, enter your move (row column):", player);
int row = int.Parse(Console.ReadLine());
int col = int.Parse(Console.ReadLine());
Step 7: Validate the player's move
Check if the player's move is valid (i.e., the row and column are within the bounds of the board and the selected space is empty). If the move is invalid, display an error message and go back to the beginning of the main game loop:

Copy code
if (row < 0 || row > 2 || col < 0 || col > 2 || board[row, col] != ' ')
{
    Console.WriteLine("Invalid move, try again!");
    Console.ReadLine();
    continue;
}
Step 8: Update the game board
Update the game board with the player's move:

Copy code
board[row, col] = player;
Step 9: Check for a win
