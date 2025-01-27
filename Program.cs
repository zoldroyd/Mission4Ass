// See https://aka.ms/new-console-template for more information
using Mission4Ass;
 
Console.WriteLine("Welcome to the tic-tac-toe game!");

char[,] boardArray = new char[3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        boardArray[i, j] = ' '; // Empty space
    }
}

Support sp = new Support(boardArray);

bool winner = false;

// inform the players of the layout
Console.WriteLine("Player 1 will use X's and player 2 will use O's");
Console.WriteLine("The board is set up with 3 rows and 3 columns.");
Console.WriteLine("You will use this logic to take your turn by specifying the column and row you want to cover.");
Console.WriteLine("For example, to place an X/O in the middle you would input row: 2 column: 2");

while (winner == false)
{
    // print out the current game board
    sp.printBoard();
    
    // ask player 1 where to play
    Console.WriteLine("Player 1 please pick a row");
    int row1 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Player 1 please pick a column");
    int col1 = Convert.ToInt32(Console.ReadLine());
    
    // print out board with player 1 choice
    boardArray[(row1 - 1), (col1 - 1)] = 'X';
    sp.printBoard();
    
    // ask player 2 where to play
    Console.WriteLine("Player 2 please pick a row");
    int row2 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Player 2 please pick a column");
    int col2 = Convert.ToInt32(Console.ReadLine());
    
    //print out board with player 2 choice
    boardArray[(row2 - 1), (col2 - 1)] = 'O';
    sp.printBoard();

    // check if someone won by calling method
    winner = sp.checkWinner();
}

// inform players that game is over and who won
Console.WriteLine("Game Over! Somebody has won!");
Console.WriteLine("Congrats Player " + sp.whoWin + " you won the game!");





