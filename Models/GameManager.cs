using System.Transactions;

namespace _032_bb_tic_tac_toe.Models;

public class GameManager
{
    private static bool IsGameWon { get; set; }
    private static bool IsGameDraw { get; set; }
    
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
    
    // Check if win / draw
    public static void IsWinOrDraw(Board board)
    {
        char topLeft = board.GameBoard[0][0];
        char topMid = board.GameBoard[0][1];
        char topRight = board.GameBoard[0][2];

        char midLeft = board.GameBoard[1][0];
        char midMid = board.GameBoard[1][1];
        char midRight = board.GameBoard[1][2];

        char botLeft = board.GameBoard[2][0];
        char botMid = board.GameBoard[2][0];
        char botRight = board.GameBoard[2][0];
        
        // TODO - Check against the 8 possible win conditions
        // Row checks
        if (topLeft == topMid && topMid == topRight) // Top
        {
            IsGameWon = true;
        }
        else if (midLeft == midMid && midMid == midRight) // Mid
        {
            IsGameWon = true;
        }
        else if (botLeft == botMid && botMid == botRight) // Bottom
        {
            IsGameWon = true;
        }
        // Column checks
        else if (topLeft == midLeft && midLeft == botLeft) // Left
        {
            IsGameWon = true;
        }
        else if (topMid == midMid && midMid == botMid) // Mid
        {
            IsGameWon = true;
        }
        else if (topRight == midRight && midRight == botRight) // Right
        {
            IsGameWon = true;
        }
        // Diagnonal checks
        else if (topLeft == midMid && midMid == botRight) // Top left to bottom right
        {
            IsGameWon = true;
        }
        else if (topRight == midMid && midMid == botLeft) // Top right to bottom left
        {
            IsGameWon = true;
        }

        if (IsGameWon)
        {
            WinGame(board);
        }
        
        // Loop through all spots
        // if all are not null && IsGameWon == false
        // call Drawstate
    }

    public static bool WinGame(Board board)
    {
        return false;
    }

    public static bool DrawGame()
    {
        return false;
    }
}