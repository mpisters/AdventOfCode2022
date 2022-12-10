using AdventOfCode2022;
using AdventOfCode2022.Core;

namespace AdventOfCode2022Tests;

public class Day4Test
{

    [Theory]
    [InlineData("../../../../AdventOfCode2022/Day4/day4inputsubsetpart1.txt", 2)]
    [InlineData("../../../../AdventOfCode2022/Day4/day4inputpart1.txt", 503)]
    public void Part1(string pathToInput, int expectedIncreasedTotal)
    {
        var filehelper = new FileReaderHelper();
        var input = filehelper.GetStringsOfFile(pathToInput);
        var testDay = new Day4();
        var solution = testDay.GetPart1(input);
        Assert.Equal(expectedIncreasedTotal, solution);
    }
    
    [Theory]
    [InlineData("../../../../AdventOfCode2022/Day4/day4inputsubsetpart2.txt",4)]
    [InlineData("../../../../AdventOfCode2022/Day4/day4inputpart1.txt", 827)]
    public void Part2(string pathToInput, int expectedIncreasedTotal)
    {
        var filehelper = new FileReaderHelper();
        var input = filehelper.GetStringsOfFile(pathToInput);
        var testDay = new Day4();
        var solution = testDay.GetPart2(input);
        Assert.Equal(expectedIncreasedTotal, solution);
    }
}