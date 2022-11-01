namespace _032_bb_tic_tac_toe.Models;

public class Board
{
    // Properties
    private char[][] GameBoard { get; set; } = new char[3][];

    public Board()
    {
        
    }

    public void DisplayGameBoard()
    {
        // Setup each row in the board
        GameBoard[0] = new char[3];
        GameBoard[1] = new char[3];
        GameBoard[2] = new char[3];
        Console.WriteLine("---------------------");
        foreach (var item in GameBoard[0])
        {
            Console.Write("| Top |");
        }
        Console.WriteLine(); // Drop down
        foreach (var item in GameBoard[1])
        {
            Console.Write("| Mid |");
        }
        Console.WriteLine(); // Drop down
        foreach (var item in GameBoard[2])
        {
            Console.Write("| Bot |");
        }
        Console.WriteLine();
        Console.WriteLine("---------------------");
    }
}