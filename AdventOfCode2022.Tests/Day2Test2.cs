using AdventOfCode2022.Core;
using AdventOfCode2022.Day2;

namespace AdventOfCode2022Tests;

public class Day2Test2
{
    [Theory]
    [InlineData("../../../../AdventOfCode2022/Day2/day2inputsubsetpart1.txt", 15)]
    [InlineData("../../../../AdventOfCode2022/Day2/day2inputpart1.txt", 10404)]
    public void TestPart1(string pathToInput, int expectedIncreasedTotal)
    {
        var filehelper = new FileReaderHelper();
        var input = filehelper.GetStringsOfFile(pathToInput);
        var day2 = new Day2();
        var solution = day2.GetDay2Part1(input);
        Assert.Equal(expectedIncreasedTotal, solution);
    }  
}