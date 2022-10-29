namespace _032_bb_tic_tac_toe.Models;

public class Board
{
    // Properties
    private char[,] GameBoard { get; set; } = new char[3, 3];

    public Board()
    {
        
    }

    public void DisplayGameBoard()
    {
        for (int i = 0; i < GameBoard.Length; i++)
        {
            if (i >= 0 && i < 3)
            {
                Console.WriteLine("Top line");
            }
            if (i >= 3 && i < 6)
            {
                Console.WriteLine("Middle Line");
            }
            if (i >= 6 && i < 9)
            {
                Console.WriteLine("Bottom Line");
            }
        }
    }
}