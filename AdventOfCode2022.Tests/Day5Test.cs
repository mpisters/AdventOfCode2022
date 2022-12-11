using AdventOfCode2022;
using AdventOfCode2022.Core;

namespace AdventOfCode2022Tests;

public class Day5Test
{
    [Theory]
    [InlineData("../../../../AdventOfCode2022/Day5/day5inputsubsetpart1.txt", "[C] [M] [Z]")]
    [InlineData("../../../../AdventOfCode2022/Day5/day5inputpart1.txt","hello2")]
    public void Part1(string pathToInput,  string expectedIncreasedTotal)
    {
        var filehelper = new FileReaderHelper();
        var input = filehelper.GetGroupedStringsOfFileSplitOnWithLines(pathToInput);
        var testDay = new Day5();
        var solution = testDay.GetPart1(input);
        Assert.Equal(expectedIncreasedTotal, solution);
    }
    
    [Theory]
    [InlineData("../../../../AdventOfCode2022/Day5/day5inputsubsetpart2.txt",4)]
    [InlineData("../../../../AdventOfCode2022/Day5/day5inputpart1.txt", 827)]
    public void Part2(string pathToInput, int expectedIncreasedTotal)
    {
        var filehelper = new FileReaderHelper();
        var input = filehelper.GetStringsOfFile(pathToInput);
        var testDay = new Day5();
        var solution = testDay.GetPart2(input);
        Assert.Equal(expectedIncreasedTotal, solution);
    }
}