namespace AdventOfCode2022.Day7;

public class Day7
{
    public int GetPart1(List<List<string>> inputValues)
    {
        var rootNode = GenericTree.NewNode("/");
        var currentNode = new Node();
        var previousNode = new Node();
        foreach (var row in inputValues)
        {
            var commandBlock = row;
            if (commandBlock.Count() == 2)
            {
                var gotoDirCommand = commandBlock[0].Trim().Split(" ");
                var nameDirectory = gotoDirCommand[1];
                if (gotoDirCommand[1] == "/")
                {
                    continue;
                }
                else
                {
                    if (nameDirectory != "..")
                    {
                        var findNode = currentNode!.child.Find(x => x.key == nameDirectory);
                        if (findNode != null)
                        {
                            previousNode = currentNode;
                            currentNode = findNode;
                        }
                    }
                }
            }
            else
            {
                foreach (var item in commandBlock)
                {
                    var parsedItem = item.Trim();
                    if (parsedItem == "ls")
                    {
                        continue;
                    }

                    var rowItems = parsedItem.Split(" ");
                    {
                        if (rowItems.Count() == 1)
                        {
                            continue;
                        }
                        var command = rowItems[0];
                        var name = rowItems[1];
                        if (command == "dir")
                        {
                            currentNode.child.Add(GenericTree.NewNode(name));
                        }
                        else
                        {
                            currentNode.values.Add(Int32.Parse(command));
                        }
                    }
                }
            }
        }

        return 0;
    }

    public int GetPart2(List<string> inputValues)
    {
        throw new NotImplementedException();
    }
}