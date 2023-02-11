using System;
using System.Collections.Generic;
using Linq.DataSources;

namespace Linq
{
    /// <summary>
    /// Considers the use of projection operations (methods 'Select', and 'SelectMany' or 'select' keyword) in LINQ queries.
    /// Projecting: <see cref="IEnumerable{TSource}"/> → <see cref="IEnumerable{TResult}"/>
    /// Projection refers to the operation of transforming an object into a new form that
    /// often consists only of those properties that will be subsequently used.
    /// </summary>
    public static class ProjectionOperations
    {
        /// <summary>
        /// Produces a sequence of integers one higher than those in an existing array of integers.
        /// </summary>
        /// <returns>The sequence of integers one higher than those in an existing array of integers.</returns>
        public static IEnumerable<int> Select()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            throw new NotImplementedException();
        }

        /// <summary>
        /// Produces a sequence of just the names of a list of products.
        /// </summary>
        /// <returns>The sequence of just the names of a list of products.</returns>
        public static IEnumerable<string> SelectProperty()
        {
            List<Product> products = Products.ProductList;

            throw new NotImplementedException();
        }

        /// <summary>
        /// Produces a sequence of strings representing the text version of a sequence of integers.
        /// </summary>
        /// <returns>The sequence of strings representing the text version of a sequence of integers.</returns>
        public static IEnumerable<string> TransformWithSelect()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            throw new NotImplementedException();
        }

        /// <summary>
        /// Produces a sequence of the uppercase and lowercase versions of each word in the original array.
        /// </summary>
        /// <returns>The sequence of the uppercase and lowercase versions of each word in the original array.</returns>
        public static IEnumerable<(string upper, string lower)> SelectByCase()
        {
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            throw new NotImplementedException();
        }

        /// <summary>
        /// Produces a sequence containing text representations of digits and whether their length is even or odd.
        /// </summary>
        /// <returns>The sequence containing text representations of digits and whether their length is even or odd.</returns>
        public static IEnumerable<(string digit, bool even)> SelectEvenOrOddNumbers()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            throw new NotImplementedException();
        }

        /// <summary>
        /// Produces a sequence containing some properties of Products, including ProductName, Category and UnitPrice.
        /// </summary>
        /// <returns>The sequence containing some properties of Products, including ProductName, Category and UnitPrice.</returns>
        public static IEnumerable<(string productName, string category, decimal price)> SelectPropertySubset()
        {
            List<Product> products = Products.ProductList;

            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines if the value of integers in an array match their position in the array.
        /// </summary>
        /// <returns>The sequence in which for each integer it is determined whether its value in the array matches their position in the array. </returns>
        public static IEnumerable<(int number, bool inPlace)> SelectWithIndex()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            throw new NotImplementedException();
        }

        /// <summary>
        /// Produce a sequence of strings representing a text version of a sequence of integers less than 5.
        /// </summary>
        /// <returns> The sequence of strings representing a text version of a sequence of integers less than 5.</returns>
        public static IEnumerable<string> SelectWithWhere()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            throw new NotImplementedException();
        }

        /// <summary>
        /// Produces all pairs of numbers from both arrays such that the number from `numbersA` is less than the number from `numbersB`.
        /// </summary>
        /// <returns>All pairs of numbers from both arrays such that the number from `numbersA` is less than the number from `numbersB`.</returns>
        public static IEnumerable<(int a, int b)> SelectFromMultipleSequences()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            throw new NotImplementedException();
        }

        /// <summary>
        /// Selects all orders where the order total is less than 500.00.
        /// </summary>
        /// <returns>All orders where the order total is less than 500.00.</returns>
        public static IEnumerable<(string customerId, int orderId, decimal total)> SelectFromChildSequence()
        {
            List<Customer> customers = Customers.CustomerList;

            throw new NotImplementedException();
        }

        /// <summary>
        /// Selects all orders where the order was made in 1998 or later.
        /// </summary>
        /// <returns>All orders where the order was made in 1998 or later.</returns>
        public static IEnumerable<(string customerId, int orderId, string orderDate)> SelectManyWithWhere()
        {
            List<Customer> customers = Customers.CustomerList;
            var dateTime = new DateTime(1998, 1, 1);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Selects all orders where the order total is greater than 2000.00.
        /// </summary>
        /// <returns>All orders where the order total is greater than 2000.00.</returns>
        public static IEnumerable<(string customerId, int orderId, decimal totalValue)> SelectManyWhereAssignment()
        {
            List<Customer> customers = Customers.CustomerList;

            throw new NotImplementedException();
        }

        /// <summary>
        /// Select all customers in Washington region ("WA") with an order date greater than or equal to the given.
        /// </summary>
        /// <returns>All customers in Washington region with an order date greater than or equal to the given.</returns>
        public static IEnumerable<(string customerId, int orderId)> SelectMultipleWhereClauses()
        {
            List<Customer> customers = Customers.CustomerList;
            DateTime cutoffDate = new DateTime(1997, 1, 1);
            string region = "WA";

            throw new NotImplementedException();
        }

        /// <summary>
        /// Selects all orders, while referring to customers by the order in which they are returned from the query.
        /// </summary>
        /// <returns>All orders info in some string format (see unit tests), while referring to customers by the order in which they are returned from the query.</returns>
        public static IEnumerable<string> IndexedSelectMany()
        {
            List<Customer> customers = Customers.CustomerList;

            throw new NotImplementedException();
        }
    }
}