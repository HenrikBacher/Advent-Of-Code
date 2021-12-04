List<string> diagnoticsReports = File.ReadAllLines("data.txt").ToList(); ;

Dictionary<int, int> occurancesOfOne = new();

foreach (var report in diagnoticsReports)
{
    for (int i = 0; i < report.Length; i++)
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

for (int i = 0; i < diagnoticsReports.First().Length; i++)
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

Console.WriteLine(String.Format("Part 1 solution: {0}", (Convert.ToInt64(gammaRate, 2) * Convert.ToInt64(epsilonRate, 2))));



for (int i = 0; i < diagnoticsReports.Count; i++)
{
    for (int j = 0; j < diagnoticsReports[i].Length; j++)
    {
        if (diagnoticsReports[i][j] == gammaRate[j])
        {
            continue;
        }
        else
        {
            break;
        }
        
    }
    Console.WriteLine(diagnoticsReports[i]);
}