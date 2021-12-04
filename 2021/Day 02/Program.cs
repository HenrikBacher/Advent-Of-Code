List<string> commands = File.ReadAllLines("data.txt").ToList();

int depth = 0;
int horizontal = 0;

foreach (var command in commands)
{
    string[] commandsParts = command.Split(' ');

    switch (commandsParts[0])
    {
        case "forward" :
            horizontal += int.Parse(commandsParts[1]);
            break;
        case "down":
            depth += int.Parse(commandsParts[1]);
            break;
        case "up":
            depth -= int.Parse(commandsParts[1]);
            break;
        default:
            break;
    }
}

Console.WriteLine(String.Format("Part 1 solution: {0}", depth * horizontal));

depth = 0;
horizontal = 0;
int aim = 0;

foreach (var command in commands)
{
    string[] commandsParts = command.Split(' ');

    switch (commandsParts[0])
    {
        case "forward":
            horizontal += int.Parse(commandsParts[1]);
            depth += aim * int.Parse(commandsParts[1]);
            break;
        case "down":
            aim += int.Parse(commandsParts[1]);
            break;
        case "up":
            aim -= int.Parse(commandsParts[1]);
            break;
    }
}

Console.WriteLine(String.Format("Part 2 solution: {0}", depth * horizontal));