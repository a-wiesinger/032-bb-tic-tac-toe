using System.Transactions;

namespace _032_bb_tic_tac_toe.Models;

public class GameManager
{
    public static bool IsGameWon { get; set; }
    public static bool IsGameDraw { get; set; }
    public static bool IsGameActive { get; set; } = true;
    
    
    
    public void StartGame()
    {
        // Vars
        // bool gameActive = true;
        
        // Create players and assign game mark
        Player playerX = new Player('X');
        Player playerO = new Player('O');
        Player[] players = new Player[] {playerX, playerO};
        
        // Create and display board
        Board board = new Board();
        board.DisplayGameBoard();
        
        // Create turn instance
        Turn turn = new Turn();

        // Play
        PlayGame(players, board, turn, IsGameActive);
    }

    public void PlayGame(Player[] players, Board board, Turn turn, bool gameActive)
    {
        turn.TakeTurn(players, board, gameActive);
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

        bool isTopRowFull = false;
        bool isMiddleRowFull = false;
        bool isBottomRowFull = false;

        // Row checks
        if (topLeft != '\0' && topMid != '\0' && topRight != '\0') // Top
        {
            isTopRowFull = true;
            if (topLeft == topMid && topMid == topRight)
            {
                IsGameWon = true;
            }
        }
        if (midLeft != '\0' && midMid != '\0' && midRight != '\0') // Mid
        {
            isMiddleRowFull = true;
            if (midLeft == midMid && midMid == midRight)
            {
                IsGameWon = true;
            }
        }
        if (botLeft != '\0' && botMid != '\0' && botRight != '\0') // Bottom
        {
            isBottomRowFull = true;
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
            IsGameActive = false;
        }

        // Check for draw
        if (IsGameWon == false && isTopRowFull && isMiddleRowFull && isBottomRowFull)
        {
            IsGameDraw = true;
            IsGameActive = false;
        }
    }

    public static void WinGame(Player player)
    {
        Console.WriteLine("You WON!!");
        Console.WriteLine(player.Mark);
        player.Wins++;
        if (player.Mark == 'X')
        {
            RecordKeeper.PlayerXWins++;
        }
        else
        {
            RecordKeeper.PlayerOWins++;
        }
    }

    public static void DrawGame()
    {
        Console.WriteLine("Draw.");
    }
}