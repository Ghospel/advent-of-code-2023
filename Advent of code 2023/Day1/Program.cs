using System.Text.RegularExpressions;

await Part2();

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

static async Task Part2()
{
    var input = await File.ReadAllLinesAsync("input.txt");
    List<string> writtenNumbers = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];

    var sum = 0;

    foreach (var line in input)
    {
        var replacedLine = line;

        replacedLine = replacedLine.Replace("one", "o1e");
        replacedLine = replacedLine.Replace("two", "t2o");
        replacedLine = replacedLine.Replace("three", "th3ee");
        replacedLine = replacedLine.Replace("four", "fo4r");
        replacedLine = replacedLine.Replace("five", "fi5e");
        replacedLine = replacedLine.Replace("six", "s6x");
        replacedLine = replacedLine.Replace("seven", "se7en");
        replacedLine = replacedLine.Replace("eight", "ei8ht");
        replacedLine = replacedLine.Replace("nine", "n9ne");

        var firstNumber = "";
        var LastNumber = "";

        foreach (var character in replacedLine)
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

        var calibrationValue = int.Parse($"{firstNumber}{LastNumber}");

        Console.WriteLine($"{line} \n{replacedLine} \n{calibrationValue}\n\n");

        sum += calibrationValue;

    }

    Console.WriteLine($"Sum of calibration values is: {sum}");
}
