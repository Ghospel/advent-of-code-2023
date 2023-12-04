




class Part
{
    public int PartNumber { get; set; }

    public static bool IsPartOfPart(char input)
    {
        var partParts = "1234567890";
        return partParts.Contains(input);
    }
}
