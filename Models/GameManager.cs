namespace _032_bb_tic_tac_toe.Models;

public class GameManager
{
    public void StartGame()
    {
        // Create players and assign game mark
        Player playerOne = new Player('X');
        Player playerTwo = new Player('O');
        
        // Create and display board
        Board board = new Board();
        board.DisplayGameBoard();
        
        // Play
        PlayGame(playerOne, playerTwo, board);
    }

    public void PlayGame(Player playerOne, Player playerTwo, Board board)
    {
        // Friendly naming for player mark
        // u - top left, i - top mid, o - top right
        // j - mid left, k - mid mid, l - mid right
        // m - bot left, , - low mid, . - low right
        // Top Row
        char topLeft = board.GameBoard[0][0];
        char topMid = board.GameBoard[0][1];
        char topRight = board.GameBoard[0][2];
        // Middle Row
        char midLeft = board.GameBoard[1][0];
        char midMid = board.GameBoard[1][1];
        char midRight = board.GameBoard[1][2];
        // Bottom Row
        char botLeft = board.GameBoard[2][0];
        char botMid = board.GameBoard[2][1];
        char botRight = board.GameBoard[2][2];
        
        // Get player input
        Console.Write("Please first select the location to make your mark: ");
        string? markLocation = Console.ReadLine();

        // Assign mark to location
        if (markLocation == "u")
        {
            topLeft = playerOne.Mark;
        }
        
        Console.WriteLine(topLeft);
    }
}