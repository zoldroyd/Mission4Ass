// See https://aka.ms/new-console-template for more information
using Mission4Ass;
 
Console.WriteLine("Welcome to the tic-tac-toe game!");

Support sp = new Support();

char[,] boardArray = new char[3, 3];

bool winner = false;

while (winner == false)
{
    // print out the current game board
    sp.printBoard(boardArray);
    
    // intereact with players
    Console.WriteLine("Player 1 will use X's and player 2 will use O's");
    Console.WriteLine("The board is set up with 3 rows and 3 columns.");
    Console.WriteLine("You will use this logic to take your turn by specifying the column and row you want to cover.");
    Console.WriteLine("For example, to place an X/O in the middle you would input row: 2 column: 2");
    
    // ask the users where they want to play by getting row and column
    Console.WriteLine("Player 1 please pick a row");
    int row1 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Player 1 please pick a column");
    int col1 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Player 2 please pick a row");
    int row2 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Player 2 please pick a column");
    int col2 = Convert.ToInt32(Console.ReadLine());
    
    boardArray[(row1 - 1), (col1 - 1)] = 'X';
    boardArray[(row2 - 1), (col2 - 1)] = 'O';
}



