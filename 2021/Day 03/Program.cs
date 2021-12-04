List<string> diagnoticsReports = File.ReadAllLines("data.txt").Select(x => x[..5]).ToList(); ;

Dictionary<int, int> occurancesOfOne = new();

foreach (var report in diagnoticsReports)
{
    for (int i = 0; i < 5; i++)
    {
        if (report[i] == '1')
        {
            if (occurancesOfOne.ContainsKey(i))
            {
                occurancesOfOne[i]++;
            }
            else
            {
                occurancesOfOne.Add(i, 1);
            }
        }
    }
}

string gammaRate = string.Empty;
string epsilonRate = string.Empty;

for (int i = 0; i < 5; i++)
{
    if (occurancesOfOne[i] >= diagnoticsReports.Count/2)
    {
        gammaRate += '1';
        epsilonRate += '0';
    }
    else
    {
        gammaRate += '0';
        epsilonRate += '1';
    }
}

Console.WriteLine(String.Format("Part 1 solution: {0}", Convert.ToInt64(gammaRate, 2) * Convert.ToInt64(epsilonRate, 2)));