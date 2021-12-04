List<int> readings = File.ReadAllLines("data.txt").Select(x => Convert.ToInt32(x)).ToList();

int increasedReadings = 0;

int previousReading = readings.First();

foreach (var currentReading in readings)
{
    if (currentReading > previousReading)
    {
        increasedReadings++;
    }
    previousReading = currentReading;
}

Console.WriteLine(String.Format("Part 1 Solution: {0}", increasedReadings));

previousReading = readings[0] + readings[1] + readings[2];

int currentIteration = 3;
increasedReadings = 0;

while (currentIteration < readings.Count)
{
    int currentReading = readings[currentIteration-2] + readings[currentIteration-1] + readings[currentIteration];
    if (currentReading > previousReading)
    {
        increasedReadings++;
    }
    previousReading = currentReading;
    currentIteration++;
}

Console.WriteLine(String.Format("Part 2 Solution: {0}", increasedReadings));