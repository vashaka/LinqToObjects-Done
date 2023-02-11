﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    /// <summary>
    /// Considers use conversion operations (methods 'ToArray, 'ToList, 'ToDictionary', 'ToLookup', 'Cast' and 'OfType') in LINQ queries.
    /// The conversion methods convert to and from other types of collections.
    /// </summary>
    public static class ConvertingDataTypes
    {
        /// <summary>
        /// Order by descending the original array and returns the result as a array.
        /// </summary>
        /// <returns>Ordered collection as array.</returns>
        public static double[] ConvertToArray()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            throw new NotImplementedException();
        }

        /// <summary>
        /// Order the original array of strings and returns the result as a collection <see cref="List{T}"/> of strings.
        /// </summary>
        /// <returns>Ordered collection of strings as <see cref="List{T}"/>.</returns>
        public static List<string> ConvertToList()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a <see cref="Dictionary{TKey,TValue}"/> with a TKey based on the 'Name' property.
        /// </summary>
        /// <returns>A <see cref="Dictionary{TKey,TValue}"/> with a key based on the 'Name' property.</returns>
        public static Dictionary<string, (string name, int score)> ConvertToDictionary()
        {
            var scoreRecords = new[]
            {
                (Name: "Alice", Score: 50),
                (Name: "Bob", Score: 40),
                (Name: "Cathy", Score: 45)
            };

            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets only the elements of the array that are of type 'double'.
        /// </summary>
        /// <returns>Only the elements of the array that are of type 'double'.</returns>
        public static IEnumerable<double> OfTypeDoubles()
        {
            object[] numbers = { null, 1.0, "two", 3, "four", 5, "six", 7.0 };

            throw new NotImplementedException();
        }
    }
}