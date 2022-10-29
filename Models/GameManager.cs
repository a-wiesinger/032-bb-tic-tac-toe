namespace _032_bb_tic_tac_toe.Models;

public class GameManager
{
    public void StartGame()
    {
        // Create players and set game mark
        Player playerOne = new Player('X');
        Player playerTwo = new Player('O');
        
        // Create and display board
        Board board = new Board();
        board.DisplayGameBoard();
    }
}