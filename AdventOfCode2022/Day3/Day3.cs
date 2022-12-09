namespace AdventOfCode2022.Day3;

public class Day3 : AdventOfCodeDay

{
    public int GetPart1(List<string> inputValues)
    {
        var total = 0;
        foreach (var value in inputValues)
        {
            var doubleCharacter = GetDoubleCharacter(value);
            var valueOfCharacter = GetValueOfCharacter(doubleCharacter);
            total += valueOfCharacter;
        }

        return total;
    }

    private int GetValueOfCharacter(char foundCharacter)
    {
        var allCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        return allCharacters.IndexOf(foundCharacter) + 1;
    }

    private Char GetDoubleCharacter(string value)
    {
        var indexOfMiddle = value.Length / 2;
        var firstPart = value.Substring(0, indexOfMiddle).ToCharArray();
        var secondPart = value.Substring(indexOfMiddle,  indexOfMiddle).ToCharArray();
        var intersection = firstPart.Intersect(secondPart).ToList();
        return intersection.First();
    }

    public int GetPart2(List<string> inputValues)
    {
        throw new NotImplementedException();
    }
}