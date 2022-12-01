using System.Collections.Immutable;

namespace AdventOfCode2022.Day1;

public class Day1
{
    public int GetDay1Part1(List<string> inputValues)
    {
        var sortedListOfAllCalories = GetSortedListOfAllCalories(inputValues);
        return sortedListOfAllCalories[0];
    }

    public int GetDay1Part2(List<string> inputValues)
    {
        var sortedListOfAllCalories = GetSortedListOfAllCalories(inputValues);
        return sortedListOfAllCalories[0] + sortedListOfAllCalories[1] + sortedListOfAllCalories[2];
    }

    private static int[] GetSortedListOfAllCalories(List<string> inputValues)
    {
        var listOfAllCalories = GetListOfAllCalories(inputValues);

        var sumAllElfs = listOfAllCalories.Select(x => x.Sum()).ToArray();
        Array.Sort(sumAllElfs);
        Array.Reverse(sumAllElfs);
        return sumAllElfs;
    }

    private static List<List<int>> GetListOfAllCalories(List<string> inputValues)
    {
        var listOfCalories = new List<int>();
        var listOfListOfAllCalories = new List<List<int>>();
        foreach (var row in inputValues)
        {
            if (row != string.Empty)
            {
                listOfCalories.Add(int.Parse(row));
            }
            else
            {
                listOfListOfAllCalories.Add(listOfCalories);
                listOfCalories = new List<int>();
            }
        }
        
        listOfListOfAllCalories.Add(listOfCalories);
        return listOfListOfAllCalories;
    }
}