
public class Game
{
    public int GameId { get; set; }

    public List<Round> Rounds { get; set; } = [];

    public bool IsPossible(int red, int green, int blue)
    {
        return Rounds.All(round => round.BlueCubes <= blue && round.RedCubes <= red && round.GreenCubes <= green);
    }
}