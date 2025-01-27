namespace Mission4Ass;

public class Support
{
    public Support()
        {
            
        }
    public void printBoard(Char[,] boardArray)
    {
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {boardArray[0, 0]}  |  {boardArray[0, 1]}  |  {boardArray[0, 2]}  ");
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {boardArray[1, 0]}  |  {boardArray[1, 1]}  |  {boardArray[1, 2]}  ");
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {boardArray[2, 0]}  |  {boardArray[2, 1]}  |  {boardArray[2, 2]}  ");
        Console.WriteLine("     |     |     ");
    }
}