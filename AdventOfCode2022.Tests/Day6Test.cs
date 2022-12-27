using AdventOfCode2022.Core;
using AdventOfCode2022.Day6;

namespace AdventOfCode2022Tests;

public class Day6Test
{
   
    [Theory]
    [InlineData("../../../../AdventOfCode2022/Day6/day6inputsubsetpart1.txt", new int[] {7,5,6, 10,11})]
    // [InlineData("../../../../AdventOfCode2022/Day6/day6inputpart1.txt", 69206)]
    public void TestPart1(string pathToInput, int[] expectedIncreasedTotal)
    {
        var filehelper = new FileReaderHelper();
        var input = filehelper.GetStringsOfFile(pathToInput);
        var day6 = new Day6();
        var solution = day6.GetPart1(input);
        Assert.Equal(expectedIncreasedTotal[0], solution[0]);
        Assert.Equal(expectedIncreasedTotal[1], solution[1]);
        Assert.Equal(expectedIncreasedTotal[2], solution[2]);
        Assert.Equal(expectedIncreasedTotal[3], solution[3]);
        Assert.Equal(expectedIncreasedTotal[4], solution[4]);
    }
    
    [Theory]
    [InlineData("../../../../AdventOfCode2022/Day6/day6inputpart1.txt", new int[] {1804})]
    public void TestPart1RealInput(string pathToInput, int[] expectedIncreasedTotal)
    {
        var filehelper = new FileReaderHelper();
        var input = filehelper.GetStringsOfFile(pathToInput);
        var day6 = new Day6();
        var solution = day6.GetPart1(input);
        Assert.Equal(expectedIncreasedTotal[0], solution[0]);
    }
        
    [Theory]
    [InlineData("../../../../AdventOfCode2022/Day6/day6inputsubsetpart1.txt", new int[] {19,23,23, 29,26})]
    // [InlineData("../../../../AdventOfCode2022/Day6/day6inputpart1.txt", 197400)]
    public void TestPart(string pathToInput, int[] expectedIncreasedTotal)
    {
        var filehelper = new FileReaderHelper();
        var input = filehelper.GetStringsOfFile(pathToInput);
        var day6 = new Day6();
        var solution = day6.GetPart2(input);
        Assert.Equal(expectedIncreasedTotal[0], solution[0]);
        Assert.Equal(expectedIncreasedTotal[1], solution[1]);
        Assert.Equal(expectedIncreasedTotal[2], solution[2]);
        Assert.Equal(expectedIncreasedTotal[3], solution[3]);
        Assert.Equal(expectedIncreasedTotal[4], solution[4]);
    }
}
