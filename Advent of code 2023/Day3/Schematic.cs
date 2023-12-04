



class Schematic
{
    public string[] Lines { get; set; }

    public static bool IsSymbol(char input)
    {
        var nonSymbols = "1234567890.";
        return !nonSymbols.Contains(input);
    }

    public string GetNeighbours(int lineNumber, int lineIndex)
    {
        string neighbours = string.Empty;

        void TryGetCharacter(int x, int y)
        {
            try
            {
                neighbours += Lines[lineNumber + x][lineIndex + y].ToString();
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        TryGetCharacter(-1, -1); // Top left
        TryGetCharacter(-1, 0);  // Above
        TryGetCharacter(-1, 1);  // Top right
        TryGetCharacter(1, 1);   // Bottom right
        TryGetCharacter(1, 0);   // Below
        TryGetCharacter(1, -1);  // Bottom left
        TryGetCharacter(0, 1);   // Right
        TryGetCharacter(0, -1);  // Left

        return neighbours;
    }
}
