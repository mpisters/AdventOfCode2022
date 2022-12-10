using System.Text.RegularExpressions;

namespace AdventOfCode2022;

public class Day4
{
    public int GetPart1(List<string> inputValues)
    {
        return GetOverlappingSections(inputValues);
    }
    
    public int GetPart2(List<string> inputValues)
    {
        return GetOverlappingSectionsPart2(inputValues);
    }


    private int GetOverlappingSections(List<string> rawListsOfsections)
    {
        var listOfMatchingSections = rawListsOfsections.Select(x =>
        {
            var elvesLists = x.Split(",").ToList();
            var sections = elvesLists.Select(GetRangeOfSectionsNumbers).ToList();
            var range1 = sections[0];
            var range2 = sections[1];
            return range1.Intersect(range2).Count() == range2.Length || range2.Intersect(range1).Count() == range1.Length;
        }).ToList();
        return listOfMatchingSections.Count(match => match == true);
    }

    private static int[] GetRangeOfSectionsNumbers(string list)
    {
        var rangeNumberArray = list.Split("-");
        var startSectionRange = int.Parse(rangeNumberArray[0]);
        var endSectionRange = int.Parse(rangeNumberArray[1]) + 1;
        var rangeSectionsNumbers = Enumerable.Range(startSectionRange, endSectionRange - startSectionRange).ToArray();
        return rangeSectionsNumbers;
    }


    private int GetOverlappingSectionsPart2(List<string> rawListsOfsections)
    {
        var listOfMatchingSections = rawListsOfsections.Select(x =>
        {
            var elvesLists = x.Split(",").ToList();
            var sections = elvesLists.Select(GetRangeOfSectionsNumbers).ToList();
            var range1 = sections[0];
            var range2 = sections[1];
            return range1.Intersect(range2).Any() || range2.Intersect(range1).Any();
        }).ToList();
        return listOfMatchingSections.Count(match => match == true);
    }
}