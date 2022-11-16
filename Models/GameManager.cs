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
        char botMid = board.GameBoard[2][1];
        char botRight = board.GameBoard[2][2];

        // Row checks
        if (topLeft != '\0' && topMid != '\0' && topRight != '\0') // Top
        {
            if (topLeft == topMid && topMid == topRight)
            {
                IsGameWon = true;
            }
        }
        if (midLeft != '\0' && midMid != '\0' && midRight != '\0') // Mid
        {
            if (midLeft == midMid && midMid == midRight)
            {
                IsGameWon = true;
            }
        }
        if (botLeft != '\0' && botMid != '\0' && botRight != '\0') // Bottom
        {
            if (botLeft == botMid && botMid == botRight)
            {
                IsGameWon = true;
            }
        }
        // Column checks
        if (topLeft != '\0' && midLeft != '\0' && botLeft != '\0') // Left
        {
            if (topLeft == midLeft && midLeft == botLeft)
                
            {
                IsGameWon = true;
            }
        }
        if (topMid != '\0' && midMid != '\0' && botMid != '\0') // Mid
        {
            if (topMid == midMid && midMid == botMid)
            {
                IsGameWon = true;
            }
        }
        if (topRight == midRight && midRight == botRight) // Right
        {
            if (topRight != '\0' && midRight != '\0' && botRight != '\0')
            {
                IsGameWon = true;
            }
        }
        // Diagnonal checks
        if (topLeft != '\0' && midMid != '\0' && botRight != '\0') // Top left to bottom right
        {
            if (topLeft == midMid && midMid == botRight)
            {
                IsGameWon = true;
            }
        }
        if (topRight != '\0' && midMid != '\0' && botLeft != '\0') // Top right to bottom left
        {
            if (topRight == midMid && midMid == botLeft)
            {
                IsGameWon = true;
            }
        }

        // Call to complete game as a win
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
        Console.WriteLine("You WON!!");
        return false;
    }

    public static bool DrawGame(Board board)
    {
        Console.WriteLine("Draw.");
        return false;
    }
}