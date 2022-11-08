namespace _032_bb_tic_tac_toe.Models;

public class Turn
{
    public void TakeTurns(Player[] players, Board board, bool gameActive)
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
        
        // Loop through player turns
        while (gameActive)
        {
            foreach (Player player in players)
            {
                // Get player input
                Console.Write("Please first select the location to make your mark: ");
                string? markLocation = Console.ReadLine();

                // Assign mark to location
                switch (markLocation)
                {
                    // Top Row
                    case "u":
                        topLeft = player.Mark;
                        board.GameBoard[0][0] = player.Mark;
                        break;
                    case "i":
                        topMid = player.Mark;
                        board.GameBoard[0][1] = player.Mark;
                        break;
                    case "o":
                        topRight = player.Mark;
                        break;
                    // Middle Row
                    case "j":
                        midLeft = player.Mark;
                        break;
                    case "k":
                        midMid = player.Mark;
                        break;
                    case "l":
                        midRight = player.Mark;
                        break;
                    // Bottom Row
                    case "m":
                        botLeft = player.Mark;
                        break;
                    case ",":
                        botMid = player.Mark;
                        break;
                    case ".":
                        botRight = player.Mark;
                        break;
                    default:
                        return;
                }
                
                // Update the game board and display
                board.DisplayGameBoard(board);
            }
        }
    }
}