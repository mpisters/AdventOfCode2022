namespace AdventOfCode2022.Day7;

public class Node
{
    public string key;
    public List<Node> child = new List<Node>();
    public List<int> values = new List<int>();
}