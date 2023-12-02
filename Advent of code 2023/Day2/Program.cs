await Part1();

static async Task Part1()
{
    var input = await File.ReadAllLinesAsync("input.txt");

    var redCubes = 12;
    var greenCubes = 13;
    var blueCubes = 14;

    List<Game> games = [];

    foreach (var line in input)
    {
        var game = new Game();

        var gameNameRounds = line.Split(':');
        var gameId = gameNameRounds[0].Split(' ')[1];

        game.GameId = int.Parse(gameId.ToString()); 
        var rounds = gameNameRounds[1].Split(';');
        foreach( var round in rounds)
        {
            var cubes = round.Split(",");

            var parsedRound = new Round();

            foreach(var cube in cubes)
            {
                var valueColor = cube.Trim().Split(' ');

                switch (valueColor[1])
                {
                    case "blue":
                        parsedRound.BlueCubes = int.Parse(valueColor[0]);
                        break;
                    case "green":
                        parsedRound.GreenCubes = int.Parse(valueColor[0]);
                        break;
                    case "red":
                        parsedRound.RedCubes = int.Parse(valueColor[0]);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            game.Rounds.Add(parsedRound);
        }

        games.Add(game);
    }

    var possibleGames = games.Where(game => game.IsPossible(redCubes, greenCubes, blueCubes));

    var sum = possibleGames.Sum(game => game.GameId);

    Console.WriteLine($"Sum of games is: {sum}");
}

static async Task Part2()
{
    var input = await File.ReadAllLinesAsync("input.txt");

    var redCubes = 12;
    var greenCubes = 13;
    var blueCubes = 14;

    List<Game> games = [];

    foreach (var line in input)
    {
        var game = new Game();

        var gameNameRounds = line.Split(':');
        var gameId = gameNameRounds[0].Split(' ')[1];

        game.GameId = int.Parse(gameId.ToString());
        var rounds = gameNameRounds[1].Split(';');
        foreach (var round in rounds)
        {
            var cubes = round.Split(",");

            var parsedRound = new Round();

            foreach (var cube in cubes)
            {
                var valueColor = cube.Trim().Split(' ');

                switch (valueColor[1])
                {
                    case "blue":
                        parsedRound.BlueCubes = int.Parse(valueColor[0]);
                        break;
                    case "green":
                        parsedRound.GreenCubes = int.Parse(valueColor[0]);
                        break;
                    case "red":
                        parsedRound.RedCubes = int.Parse(valueColor[0]);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            game.Rounds.Add(parsedRound);
        }

        games.Add(game);
    }

    var possibleGames = games.Where(game => game.IsPossible(redCubes, greenCubes, blueCubes));

    var sumSetPower = games.Sum(game => game.MinimumSetPower());

    Console.WriteLine($"Sum of minimum set power is: {sumSetPower}");
}