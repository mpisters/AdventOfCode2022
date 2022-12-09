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
    
    public int GetPart2(List<string> inputValues)
    {
        var total = 0;
        for (var i = 0; i < inputValues.Count; i+=3)
        {
            var matchingCharacter = GetMatchingCharacter(inputValues, i);
            var valueOfCharacter = GetValueOfCharacter(matchingCharacter);
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



    private Char GetMatchingCharacter(List<string> inputValues, int i)
    {
;
        var firstChunk = inputValues[i];
        var secondChunk = inputValues[i + 1];
        var thirdChunk = inputValues[i + 2];
        return firstChunk.Intersect(secondChunk).Intersect(thirdChunk).ToList().First();
    }
}