using AdventOfCode2022.Core;
using AdventOfCode2022.Day1;
using AdventOfCode2022.TestDay;

namespace AdventOfCode2022Tests;

public class Day1Test
{
   
        [Theory]
        [InlineData("../../../../AdventOfCode2022/Day1/day1inputsubsetpart1.txt", 24000)]
        [InlineData("../../../../AdventOfCode2022/Day1/day1inputpart1.txt", 69206)]
        public void TestPart1(string pathToInput, int expectedIncreasedTotal)
        {
            var filehelper = new FileReaderHelper();
            var input = filehelper.GetStringsOfFile(pathToInput);
            var day1 = new Day1();
            var solution = day1.GetDay1Part1(input);
            Assert.Equal(expectedIncreasedTotal, solution);
        }
}