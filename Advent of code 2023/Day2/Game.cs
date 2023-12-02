
public class Game
{
    public int GameId { get; set; }

    public List<Round> Rounds { get; set; } = [];

    public bool IsPossible(int red, int green, int blue)
    {
        return Rounds.All(round => round.BlueCubes <= blue && round.RedCubes <= red && round.GreenCubes <= green);
    }

    public int MinimumSetPower()
    {
        var red = Rounds.Max(round => round.RedCubes);
        var green = Rounds.Max(round => round.GreenCubes);
        var blue = Rounds.Max(round => round.BlueCubes);

        return red * green * blue;
    }
}