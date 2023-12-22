namespace AdventOfCode2022.Core;

public class FileReaderHelper
{
    public List<string> GetStringsOfFile(string pathToInput)
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), pathToInput);
        var inputLines = File.ReadAllLines(path);
        var lines = new List<string>(inputLines);

        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }

        return lines;
    }
    public List<List<string>> GetGroupedStringsOfFileSplitOnWithLines(string pathToInput, string[]? pattern = null)
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), pathToInput);
        var file = File.ReadAllText(path);
        var inputLines = file.Split(pattern ?? new string[] { "\n\n" },
            StringSplitOptions.RemoveEmptyEntries);
        return inputLines.ToList().Select(block =>
        {
            var values = block.Split("\n");
            return values.ToList();
        }).ToList();
    }
}