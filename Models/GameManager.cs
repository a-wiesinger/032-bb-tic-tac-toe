namespace _032_bb_tic_tac_toe.Models;

public class GameManager
{
    public void StartGame()
    {
        // Vars
        bool gameActive = true;
        
        // Create players and assign game mark
        Player playerOne = new Player('X');
        Player playerTwo = new Player('O');
        Player[] players = new Player[] {playerOne, playerTwo};
        
        // Create and display board
        Board board = new Board();
        board.DisplayGameBoard();
        
        // Create turn instance
        Turn turn = new Turn();

        // Play
        PlayGame(players, board, turn, gameActive);
    }

    public void PlayGame(Player[] players, Board board, Turn turn, bool gameActive)
    {
        turn.TakeTurns(players, board, gameActive);
    }

    // Clean up the console
    public static void Clear()
    {
        Console.Clear();
    }
}