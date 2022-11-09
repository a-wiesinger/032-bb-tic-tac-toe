namespace _032_bb_tic_tac_toe.Models;

public class Turn
{
    public void TakeTurns(Player[] players, Board board, bool gameActive)
    {
        // Grid layout is as follows:
        // u - top left, i - top mid, o - top right
        // j - mid left, k - mid mid, l - mid right
        // m - bot left, , - low mid, . - low right

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
                        if (board.GameBoard[0][0] == '\0')
                        {
                            board.GameBoard[0][0] = player.Mark;
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
                board.DisplayGameBoard(board);
            }
        }
    }
}