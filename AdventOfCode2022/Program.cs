// See https://aka.ms/new-console-template for more information


var path = Path.Combine(Directory.GetCurrentDirectory(), "../../../TestDay/testinput.txt");


var inputLines = System.IO.File.ReadAllLines(path);
var lines = new List<string>(inputLines);

foreach (var line in lines)
{
    Console.WriteLine(line);
}


