await Part1();

static async Task Part1()
{
    var input = await File.ReadAllLinesAsync("input.txt");

    var schematic = new Schematic
    {
        Lines = input
    };

    var parts = new List<Part>();

    for (int i = 0; i < schematic.Lines.Length; i++)
    {
        string? line = schematic.Lines[i];
        var part = new Part();
        string allNeighbours = string.Empty;
        string currentPartNumber = string.Empty;

        for (int j = 0; j < line.Length; j++)
        {
            if (j == line.Length - 1 && Part.IsPartOfPart(line[j]))
            {
                if (allNeighbours.Distinct().Any(Schematic.IsSymbol))
                {
                    currentPartNumber += line[j].ToString();
                    part.PartNumber = int.Parse(currentPartNumber);
                    parts.Add(part);
                    part = new Part();
                    currentPartNumber = string.Empty;
                    allNeighbours = string.Empty;
                }
                else
                {
                    currentPartNumber = string.Empty;
                    allNeighbours = string.Empty;
                }
            }
            if (Part.IsPartOfPart(line[j]))
            {
                allNeighbours += schematic.GetNeighbours(i, j);
                currentPartNumber += line[j].ToString();
            }
            else
            {
                if (allNeighbours.Distinct().Any(Schematic.IsSymbol))
                {
                    part.PartNumber = int.Parse(currentPartNumber);
                    parts.Add(part);
                    part = new Part();
                    currentPartNumber = string.Empty;
                    allNeighbours = string.Empty;
                }
                else
                {
                    currentPartNumber = string.Empty;
                    allNeighbours = string.Empty;
                }
            }
        }
    }

    Console.WriteLine($"Sum of all part numbers: {parts.Sum(x => x.PartNumber)}");
}
