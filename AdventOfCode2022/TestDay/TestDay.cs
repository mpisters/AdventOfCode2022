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
    
    public int GetDay1Part2(List<string> input)
    {
        var totalIncrease = 0;
        List<int> inputNumbers = input.Select((x) => int.Parse(x)).ToList();
        var total = inputNumbers.Count - 2;
        var sum = 0;
        for (var i = 0; i < total; i++)
        {
            var newSum = inputNumbers[i] + inputNumbers[i + 1] + inputNumbers[i + 2];
            if ( newSum > sum)
            {
                totalIncrease++;
                sum = newSum;
            }
        }

        return totalIncrease;
    }
}