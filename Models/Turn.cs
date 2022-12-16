namespace _032_bb_tic_tac_toe.Models;

public class Turn
{
    public void TakeTurn(Player[] players, Board board, bool isGameActive)
    {
        // Grid layout is as follows:
        // u - top left, i - top mid, o - top right
        // j - mid left, k - mid mid, l - mid right
        // m - bot left, , - low mid, . - low right

        // Loop through player turns
        while (GameManager.IsGameActive)
        {
            foreach (Player player in players)
            {
                if (GameManager.IsGameActive)
                {
                    // Get player input
                Console.Write("Please select the location to make your mark: ");
                string? markLocation = Console.ReadLine();

                // Assign mark to location
                switch (markLocation)
                {
                    // Top Row
                    case "u":
                        if (board.GameBoard[0][0] == '\0')
                        {
                            board.GameBoard[0][0] = player.Mark;
                            GameManager.IsWinOrDraw(board);
                        }
                        else
                        {
                            Console.WriteLine("Try again.");
                            Console.ReadLine();
                        }
                        break;
                    case "i":
                        if (board.GameBoard[0][1] == '\0')
                        {
                            board.GameBoard[0][1] = player.Mark;
                            GameManager.IsWinOrDraw(board);
                        }
                        else
                        {
                            Console.WriteLine("Try again.");
                            Console.ReadLine();
                        }
                        break;
                    case "o":
                        if (board.GameBoard[0][2] == '\0')
                        {
                            board.GameBoard[0][2] = player.Mark;
                            GameManager.IsWinOrDraw(board);
                        }
                        else
                        {
                            Console.WriteLine("Try again.");
                            Console.ReadLine();
                        }
                        break;
                    // Middle Row
                    case "j":
                        if (board.GameBoard[1][0] == '\0')
                        {
                            board.GameBoard[1][0] = player.Mark;
                            GameManager.IsWinOrDraw(board);
                        }
                        else
                        {
                            Console.WriteLine("Try again.");
                            Console.ReadLine();
                        }
                        break;
                    case "k":
                        if (board.GameBoard[1][1] == '\0')
                        {
                            board.GameBoard[1][1] = player.Mark;
                            GameManager.IsWinOrDraw(board);
                        }
                        else
                        {
                            Console.WriteLine("Try again.");
                            Console.ReadLine();
                        }
                        break;
                    case "l":
                        if (board.GameBoard[1][2] == '\0')
                        {
                            board.GameBoard[1][2] = player.Mark;
                            GameManager.IsWinOrDraw(board);
                        }
                        else
                        {
                            Console.WriteLine("Try again.");
                            Console.ReadLine();
                        }
                        break;
                    // Bottom Row
                    case "m":
                        if (board.GameBoard[2][0] == '\0')
                        {
                            board.GameBoard[2][0] = player.Mark;
                            GameManager.IsWinOrDraw(board);
                        }
                        else
                        {
                            Console.WriteLine("Try again.");
                            Console.ReadLine();
                        }
                        break;
                    case ",":
                        if (board.GameBoard[2][1] == '\0')
                        {
                            board.GameBoard[2][1] = player.Mark;
                            GameManager.IsWinOrDraw(board);
                        }
                        else
                        {
                            Console.WriteLine("Try again.");
                            Console.ReadLine();
                        }
                        break;
                    case ".":
                        if (board.GameBoard[2][2] == '\0')
                        {
                            board.GameBoard[2][2] = player.Mark;
                            GameManager.IsWinOrDraw(board);
                        }
                        else
                        {
                            Console.WriteLine("Try again.");
                            Console.ReadLine();
                        }
                        break;
                    default:
                        return;
                }
                
                // Update the game board and display
                board.DisplayGameBoard(board, GameManager.IsGameWon, GameManager.IsGameDraw);
                }
            }
        }
    }
}