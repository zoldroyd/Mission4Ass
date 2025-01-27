namespace Mission4Ass;

public class Support
{
    public char[,] BoardArray = new char[3, 3];

    public Support(char[,] boardArray)
        {
        BoardArray = boardArray;
        }
    public void printBoard()
    {

        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {BoardArray[0, 0]}  |  {BoardArray[0, 1]}  |  {BoardArray[0, 2]}  ");
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine($"  {BoardArray[1, 0]}  |  {BoardArray[1, 1]}  |  {BoardArray[1, 2]}  ");
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine($"  {BoardArray[2, 0]}  |  {BoardArray[2, 1]}  |  {BoardArray[2, 2]}  ");
        Console.WriteLine("     |     |     ");
    }

    public bool checkWinner()
    {
        bool winner = false;

        for (int i = 0; i < 3; i++)
        {
            if (BoardArray[0, i] == BoardArray[1, i] && BoardArray[0, i] == BoardArray[2, i])
            {
                winner = true;
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (BoardArray[i, 0] == BoardArray[i, 1] && BoardArray[i, 0] == BoardArray[i, 2])
            {
                winner = true;
            }
        }

        if (BoardArray[0, 0] == BoardArray[1, 1] && BoardArray[0, 0] == BoardArray[2, 2])
        {
            winner = true;
        }

        if (BoardArray[2, 0] == BoardArray[1, 1] && BoardArray[2, 0] == BoardArray[0, 2])
        {
            winner = true;
        }

        return winner;
    }
}