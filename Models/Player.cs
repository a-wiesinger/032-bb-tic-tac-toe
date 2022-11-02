namespace _032_bb_tic_tac_toe.Models;

public class Player
{
    // Properties
    public int Wins { get; set; }
    public int Losses { get; set; }
    public char Mark { get; set; }

    public Player(char mark)
    {
        Mark = mark;
    }
}