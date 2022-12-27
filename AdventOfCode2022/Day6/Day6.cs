namespace AdventOfCode2022.Day6;

public class Day6

{
    public List<int> GetPart1(List<string> inputValues, int totalDistinctValues)
    {
        return inputValues.Select(row => GetFirstMarker(row, totalDistinctValues)).ToList();
    }

    private int GetFirstMarker(string signal, int totalDistinctValues)
    {
        var score = int.MaxValue;
        for (var i = 0; i < signal.Count() - (totalDistinctValues - 1); i++)
        {
            var substring = signal.Substring(i, totalDistinctValues);
            var uniqueCharacters = new HashSet<char>();
            foreach (var character in substring)
            {
                uniqueCharacters.Add(character);
            }

            if (uniqueCharacters.Count != totalDistinctValues)
            {
                continue;
            };
            score = i + totalDistinctValues;
            break;
        }

        return score;
    }

    public List<int> GetPart2(List<string> inputValues, int totalDistinctValues)
    {
        return inputValues.Select(row => GetFirstMarker(row, totalDistinctValues)).ToList();
    }
}