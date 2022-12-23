namespace _032_bb_tic_tac_toe.Models;

public class Board
{
    // Properties
    public char[][] GameBoard { get; set; } = new char[3][];

    // Show initial board setup
    public void DisplayGameBoard()
    {
        // Setup each row in the board
        GameBoard[0] = new char[3]; // Top row
        GameBoard[1] = new char[3]; // Middle row
        GameBoard[2] = new char[3]; // Bottom row
        Console.WriteLine("---------------");
        foreach (var item in GameBoard[0])
        {
            Console.Write("|   |");
        }
        Console.WriteLine();
        Console.WriteLine("---------------"); // Drop down
        foreach (var item in GameBoard[1])
        {
            Console.Write("|   |");
        }
        Console.WriteLine();
        Console.WriteLine("---------------"); // Drop down
        foreach (var item in GameBoard[2])
        {
            Console.Write("|   |");
        }
        Console.WriteLine();
        Console.WriteLine("---------------");
    }
    
    // Called after each piece is played
    public void DisplayGameBoard(Board board, bool isGameWon, bool isGameDraw, Player player)
    {
        // Clear console
        GameManager.Clear();
            
        Console.WriteLine("---------------");
        foreach (var item in board.GameBoard[0])
        {
            if (item == '\0')
            {
                Console.Write("|   |");
            }
            else
            {
                Console.Write($"| {item} |");
            }
        }
        Console.WriteLine();
        Console.WriteLine("---------------"); // Drop down
        foreach (var item in GameBoard[1])
        {
            if (item == '\0')
            {
                Console.Write("|   |");
            }
            else
            {
                Console.Write($"| {item} |");
            }
        }
        Console.WriteLine();
        Console.WriteLine("---------------"); // Drop down
        foreach (var item in GameBoard[2])
        {
            if (item == '\0')
            {
                Console.Write("|   |");
            }
            else
            {
                Console.Write($"| {item} |");
            }
        }
        Console.WriteLine();
        Console.WriteLine("---------------");

        if (isGameWon) GameManager.WinGame(player);
        if (isGameDraw) GameManager.DrawGame();
    }
}