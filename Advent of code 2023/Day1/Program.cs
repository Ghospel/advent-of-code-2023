await Part1();

static async Task Part1()
{
    var input = await File.ReadAllLinesAsync("input.txt");

    var sum = 0;

    foreach (var line in input)
    {
        var firstNumber = "";
        var LastNumber = "";

        foreach (var character in line)
        {
            if (int.TryParse(character.ToString(), out var number))
            {
                if (string.IsNullOrEmpty(firstNumber))
                {
                    firstNumber = character.ToString();
                }

                if (string.IsNullOrEmpty(LastNumber))
                {
                    LastNumber = character.ToString();
                }

                if (LastNumber != character.ToString())
                {
                    LastNumber = character.ToString();
                }
            }
        }

        sum += int.Parse($"{firstNumber}{LastNumber}");

    }

    Console.WriteLine($"Sum of calibration values is: {sum}");
}