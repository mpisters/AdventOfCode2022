using AdventOfCode2022.Core;
using AdventOfCode2022.Day3;

namespace AdventOfCode2022Tests;

public class Day3Test
{
    [Theory]
    [InlineData("../../../../AdventOfCode2022/Day3/day3inputsubsetpart1.txt", 157)]
    [InlineData("../../../../AdventOfCode2022/Day3/day3inputpart1.txt", 7716)]
    public void Part1(string pathToInput, int expectedIncreasedTotal)
    {
        var filehelper = new FileReaderHelper();
        var input = filehelper.GetStringsOfFile(pathToInput);
        var testDay = new Day3();
        var solution = testDay.GetPart1(input);
        Assert.Equal(expectedIncreasedTotal, solution);
    }
    
    [Theory]
    [InlineData("../../../../AdventOfCode2022/Day3/day3inputsubsetpart1.txt",70)]
    [InlineData("../../../../AdventOfCode2022/Day3/day3inputpart1.txt", 2973)]
    public void Part2(string pathToInput, int expectedIncreasedTotal)
    {
        var filehelper = new FileReaderHelper();
        var input = filehelper.GetStringsOfFile(pathToInput);
        var testDay = new Day3();
        var solution = testDay.GetPart2(input);
        Assert.Equal(expectedIncreasedTotal, solution);
    }
}