namespace AdventOfCode2022.Day1;

public class Day1
{
    public int GetDay1Part1(List<string> inputValues)
    {
        var maxTotal = 0;
        var currentTotal = 0;
        var totalItems = 0;
        for (var i = 0; i < inputValues.Count; i++)
        {
            var row = inputValues[i];
            if (row != string.Empty)
            {
                currentTotal += int.Parse(row);
                totalItems++;
            }
            else
            {
                
                if (currentTotal > maxTotal)
                {
                    maxTotal = currentTotal;
                    currentTotal = 0;
                    totalItems = 0;
                }
                else
                {
                    currentTotal = 0;
                    totalItems = 0;
                }
            }
        }

        return maxTotal;
    }
}