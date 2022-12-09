using AdventOfCode2022.Core;
using AdventOfCode2022.Day2;

namespace AdventOfCode2022Tests;

public class Day2Test
{
    [Theory]
    [InlineData("../../../../AdventOfCode2022/Day2/day2inputsubsetpart1.txt", 15)]
    [InlineData("../../../../AdventOfCode2022/Day2/day2inputpart1.txt", 10404)]
    public void TestPart1(string pathToInput, int expectedIncreasedTotal)
    {
        var fileHelper = new FileReaderHelper();
        var input = fileHelper.GetStringsOfFile(pathToInput);
        var day2 = new Day2();
        var solution = day2.GetPart1(input);
        Assert.Equal(expectedIncreasedTotal, solution);
    }  
    
    [Theory]
    [InlineData("../../../../AdventOfCode2022/Day2/day2inputsubsetpart1.txt", 12)]
    [InlineData("../../../../AdventOfCode2022/Day2/day2inputpart1.txt", 10334)]
    public void TestPart2(string pathToInput, int expectedIncreasedTotal)
    {
        var fileHelper = new FileReaderHelper();
        var input = fileHelper.GetStringsOfFile(pathToInput);
        var day2 = new Day2();
        var solution = day2.GetPart2(input);
        Assert.Equal(expectedIncreasedTotal, solution);
    }  
}