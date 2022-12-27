namespace AdventOfCode2022.Day6;

public class Day6

{
    public List<int> GetPart1(List<string> inputValues)
    {
        return inputValues.Select(GetFirstMarker).ToList();
    }

    private int GetFirstMarker(string signal)
    {
        var score = int.MaxValue;
        for (var i = 0; i < signal.Count() - 3; i++)
        {
            var lengthOfSubpart = 4;
            var substring = signal.Substring(i, lengthOfSubpart);
            var uniqueCharacters = new HashSet<char>();
            foreach (var character in substring)
            {
                uniqueCharacters.Add(character);
            }

            if (uniqueCharacters.Count != lengthOfSubpart)
            {
                continue;
            };
            score = i + lengthOfSubpart;
            break;
        }

        return score;
    }

    public List<int> GetPart2(List<string> inputValues)
    {
        throw new NotImplementedException();
    }
}