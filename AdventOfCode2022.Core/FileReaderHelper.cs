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
}