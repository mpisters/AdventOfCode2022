using AdventOfCode2022.Core;
using AdventOfCode2022.Day7;

namespace AdventOfCode2022Tests;

public class Day7Test
{
    [Theory]
    [InlineData("../../../../AdventOfCode2022/Day7/day7inputpart1.txt",100)]
    public void Part1(string pathToInput,  int expectedIncreasedTotal)
    {
        var filehelper = new FileReaderHelper();
        var input = filehelper.GetGroupedStringsOfFileSplitOnWithLines(pathToInput, new string[]{"$"});
        var testDay = new Day7();
        var solution = testDay.GetPart1(input);
        Assert.Equal(expectedIncreasedTotal, solution);
    }
    
    [Theory]
    [InlineData("../../../../AdventOfCode2022/Day7/day7inputpart1.txt",100)]
    public void Part2(string pathToInput, int expectedIncreasedTotal)
    {
        var filehelper = new FileReaderHelper();
        var input = filehelper.GetStringsOfFile(pathToInput);
        var testDay = new Day7();
        var solution = testDay.GetPart2(input);
        Assert.Equal(expectedIncreasedTotal, solution);
    }
}
