using AdventOfCode2022.Core;
using AdventOfCode2022.TestDay;

namespace AdventOfCode2022Tests;

public class TestDay1Test
{
    [Theory]
    [InlineData("../../../../AdventOfCode2022/TestDay/testinputsubsetpart1.txt", 7)]
    [InlineData("../../../../AdventOfCode2022/TestDay/testinputpart1.txt", 1521)]
    public void TestPart1(string pathToInput, int expectedIncreasedTotal)
    {
        var filehelper = new FileReaderHelper();
        var input = filehelper.GetStringsOfFile(pathToInput);
        var testDay = new TestDay();
        var solution = testDay.GetDay1Part1(input);
        Assert.Equal(expectedIncreasedTotal, solution);
    }
    
    [Theory]
    [InlineData("../../../../AdventOfCode2022/TestDay/testinputpart2subset.txt",5)]
    [InlineData("../../../../AdventOfCode2022/TestDay/testinputpart1.txt", 1543)]
    public void TestPart2(string pathToInput, int expectedIncreasedTotal)
    {
        var filehelper = new FileReaderHelper();
        var input = filehelper.GetStringsOfFile(pathToInput);
        var testDay = new TestDay();
        var solution = testDay.GetDay1Part2(input);
        Assert.Equal(expectedIncreasedTotal, solution);
    }
}