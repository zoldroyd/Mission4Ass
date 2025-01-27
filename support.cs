namespace Mission4Ass;

public class Support
{
    public char[,] BoardArray = new char[3, 3];

    public int whoWin = 2;

    public Support(char[,] boardArray)
        {
        BoardArray = boardArray;
        }
    public void printBoard()
    {

        Console.WriteLine($"  {BoardArray[0, 0]}  |  {BoardArray[0, 1]}  |  {BoardArray[0, 2]}  ");
        Console.WriteLine("____|____|____");
        Console.WriteLine($"  {BoardArray[1, 0]}  |  {BoardArray[1, 1]}  |  {BoardArray[1, 2]}  ");
        Console.WriteLine("____|____|____");
        Console.WriteLine($"  {BoardArray[2, 0]}  |  {BoardArray[2, 1]}  |  {BoardArray[2, 2]}  ");
        Console.WriteLine("     |     |     ");
    }

    public bool checkWinner()
    {
        bool winner = false;


        for (int i = 0; i < 3; i++)
        {
            if (BoardArray[0, i] == 'X' && BoardArray[1, i] =='X' && BoardArray[2, i] == 'X')
            {
                winner = true;
                whoWin = 1;
            }
        }

        for (int i = 0; i < 3; i++)
        {
            if (BoardArray[i, 0] == 'X' && BoardArray[i, 1] == 'X' && BoardArray[i, 2] == 'X')
            {
                winner = true;
                whoWin = 1;

            }
        }

        if (BoardArray[0, 0] == 'X' && BoardArray[1, 1] == 'X' && BoardArray[2, 2] == 'X')
        {
            winner = true;
            whoWin = 1;

        }
        if (BoardArray[2, 0] == 'X' && BoardArray[1, 1] == 'X' && BoardArray[0, 2] == 'X')

        {
            winner = true;
            whoWin = 1;

        }




        for (int i = 0; i < 3; i++)
        {
            if (BoardArray[0, i] == 'O' && BoardArray[1, i] == 'O' && BoardArray[2, i] == 'O')
            {
                winner = true;
                whoWin = 0;

            }
        }

        for (int i = 0; i < 3; i++)
        {
            if (BoardArray[i, 0] == 'O' && BoardArray[i, 1] == 'O' && BoardArray[i, 2] == 'O')
            {
                winner = true;
                whoWin = 0;

            }
        }

        if (BoardArray[0, 0] == 'O' && BoardArray[1, 1] == 'O' && BoardArray[2, 2] == 'O')
        {
            winner = true;
            whoWin = 0;

        }
        if (BoardArray[2, 0] == 'O' && BoardArray[1, 1] == ')' && BoardArray[0, 2] == 'O')

        {
            winner = true;
            whoWin = 0;

        }

        return winner;
    }
}