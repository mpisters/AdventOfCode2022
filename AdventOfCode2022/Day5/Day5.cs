using System.Text.RegularExpressions;

namespace AdventOfCode2022;

public class Day5
{
    public string GetPart1(List<List<string>> inputValues)
    {
        var startPositionAllCrates = GetStartPositionsOfAllCrates(inputValues[0]);
        var endPositionOfAllCrates = GetEndPositionOfAllCrates(inputValues[1], startPositionAllCrates);
        return GetHighestCrates(endPositionOfAllCrates);
    }

    public string GetPart2(List<List<string>> inputValues)
    {
        var startPositionAllCrates = GetStartPositionsOfAllCrates(inputValues[0]);
        var endPositionOfAllCrates = GetEndPositionOfAllCrates2(inputValues[1], startPositionAllCrates);
        return GetHighestCrates(endPositionOfAllCrates);
    }

    private string GetHighestCrates(Dictionary<int, List<string>> endPositionOfAllCrates)
    {
        var listAllHighestCrates = endPositionOfAllCrates.Select(item => item.Value)
            .Select(listCrates => listCrates[^1]).ToList();

        return string.Join(" ", listAllHighestCrates);
    }

    private Dictionary<int, List<string>> GetEndPositionOfAllCrates(List<string> inputValues,
        Dictionary<int, List<string>> mappedPositions)
    {
        foreach (var input in inputValues)
        {
            var inputArray = input.Split(" ");
            var totalMoves = int.Parse(inputArray[1]);
            var startPosition = int.Parse(inputArray[3]);
            var endPosition = int.Parse(inputArray[5]);

            var startingArray = mappedPositions[startPosition];

            startingArray.Reverse();
            var itemsToMove = startingArray.Take(totalMoves);

            var endArray = mappedPositions[endPosition];
            var concatenatedEndArray = endArray.Concat(itemsToMove);
            mappedPositions[endPosition] = concatenatedEndArray.ToList();

            startingArray.Reverse();
            var newStartingArray = startingArray.Take(startingArray.Count - totalMoves);
            mappedPositions[startPosition] = newStartingArray.ToList();
        }

        return mappedPositions;
    }

    private Dictionary<int, List<string>> GetEndPositionOfAllCrates2(List<string> inputValues,
        Dictionary<int, List<string>> mappedPositions)
    {
        foreach (var input in inputValues)
        {
            var inputArray = input.Split(" ");
            var totalMoves = int.Parse(inputArray[1]);
            var startPosition = int.Parse(inputArray[3]);
            var endPosition = int.Parse(inputArray[5]);

            var startingArray = mappedPositions[startPosition];

            startingArray.Reverse();
            var itemsToMove = startingArray.Take(totalMoves).Reverse();

            var endArray = mappedPositions[endPosition];
            var concatenatedEndArray = endArray.Concat(itemsToMove);
            mappedPositions[endPosition] = concatenatedEndArray.ToList();

            startingArray.Reverse();
            var newStartingArray = startingArray.Take(startingArray.Count - totalMoves);
            mappedPositions[startPosition] = newStartingArray.ToList();
        }

        return mappedPositions;
    }

    private Dictionary<int, List<string>> GetStartPositionsOfAllCrates(List<string> inputValue)
    {
        var inputArray = inputValue.ToArray();
        Array.Reverse(inputArray);
        var indexes = inputArray[0].Split("  ").Select(item => int.Parse(item.Trim())).ToList();
        var mappedPositions = indexes.ToDictionary(index => index, index => new List<string>());
        foreach (var input in inputArray.Skip(1))
        {
            var positionsInArray = Regex.Replace(input, @"\s(\s{2})\s", " [$]").Trim().Split(" ");
            for (var i = 0; i < indexes.Count; i++)
            {
                var index = i + 1;
                var value = mappedPositions[index];
                if (positionsInArray[i] != "[$]")
                {
                    value.Add(positionsInArray[i]);
                }

                mappedPositions[index] = value;
            }
        }

        return mappedPositions;
    }
}