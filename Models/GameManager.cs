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
        // Location of player mark
        // u - top left, i - top mid, o - top right
        // j - mid left, k - mid mid, l - mid right
        // m - bot left, , - low mid, . - low right
        Console.Write("Please first select the location to make your mark: ");
        string? markLocation = Console.ReadLine();
    }
}