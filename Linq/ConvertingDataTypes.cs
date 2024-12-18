using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public static class ConvertingDataTypes
    {
        public static double[] ConvertToArray()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            return doubles.OrderByDescending(d => d).ToArray();
        }

        public static List<string> ConvertToList()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            return words.OrderBy(word => word).ToList();
        }

        public static Dictionary<string, (string name, int score)> ConvertToDictionary()
        {
            var scoreRecords = new[]
            {
                (Name: "Alice", Score: 50),
                (Name: "Bob", Score: 40),
                (Name: "Cathy", Score: 45)
            };

            return scoreRecords.ToDictionary(record => record.Name, record => (record.Name, record.Score));
        }

        public static IEnumerable<double> OfTypeDoubles()
        {
            object[] numbers = { null, 1.0, "two", 3, "four", 5, "six", 7.0 };
            return numbers.OfType<double>();
        }
    }
}
