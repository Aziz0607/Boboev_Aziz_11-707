using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var days = new string[31];
            var birthCounts = new double[31];

            // X axis (days) 
            for (int i = 1; i <= 31; i++)
            {
                days[i - 1] = i.ToString();
            }

            // Y values (counts of birthes) 
            foreach (var nameSample in names)
            {
                if (nameSample.Name == name)
                {
                    if (nameSample.BirthDate.Day != 1) birthCounts[nameSample.BirthDate.Day - 1]++;
                }
            }

            return new HistogramData(string.Format("Рождаемость людей с именем '{0}'", name), days, birthCounts);
        }
    }
}
