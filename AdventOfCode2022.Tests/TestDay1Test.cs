using AdventOfCode2022.Core;
using AdventOfCode2022.TestDay;

namespace AdventOfCode2022Tests;

public class TestDay1Test
{
    [Theory]
    [InlineData("../../../../AdventOfCode2022/TestDay/testinputsubset.txt", 7)]
    [InlineData("../../../../AdventOfCode2022/TestDay/testinput.txt", 1521)]
    public void TestPart1(string pathToInput, int expectedIncreasedTotal)
    {
        var filehelper = new FileReaderHelper();
        var input = filehelper.GetStringsOfFile(pathToInput);
        var testDay = new TestDay();
        var solution = testDay.GetDay1Part1(input);
        Assert.Equal(expectedIncreasedTotal, solution);
    }
}