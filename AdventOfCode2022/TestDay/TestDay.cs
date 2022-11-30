namespace AdventOfCode2022.TestDay;

public class TestDay
{
    public int GetDay1Part1(List<string> input)
    {
        var totalIncrease = 0;
        var previousNumber = 0;
        var index = 0;
        input.Select((x) => int.Parse(x)).Aggregate(previousNumber, (prev, curr) =>  {
            if (index == 0)
            {
                index++;
                return curr;
            }
            if (curr - prev > 0)
            {
                totalIncrease += 1;
            }
            return curr;
        });

        return totalIncrease;
    }
}