using System;

namespace Strings
{
    public static class Interpolation
    {
        /// <summary>
        /// Returns a greeting that starts with "Hello".
        /// </summary>
        public static string GetHelloGreeting(string name)
        {
            return $"Hello, {name}!";
        }

        /// <summary>
        /// Returns a greeting that starts with a greeting argument.
        /// </summary>
        public static string GetGreeting(string greeting, string name)
        {
            return $"{greeting}, {name}!";
        }

        /// <summary>
        /// Returns a phrase that contains a square number.
        /// </summary>
        public static string GetSquareNumber(int i)
        {
            return $"The square number of {i} is {i * i}.";
        }

        /// <summary>
        /// Returns a phrase that contains a total price.
        /// </summary>
        public static string GetTotalPrice(double price, int items, double discount)
        {
            double totalPrice = price * items * discount;
            return $"The price of all items is {totalPrice}.";
        }

        /// <summary>
        /// Returns a phrase that contains a sequence of numbers.
        /// </summary>
        public static string GetSequenceOfNumbers(int[] numbers)
        {
            return $"The sequence is {{{string.Join(",", numbers)}}}.";
        }

        /// <summary>
        /// Returns a phrase that contains the length of a sequence.
        /// </summary>
        public static string GetSequenceOfNumbersLength(string sequence)
        {
            if (sequence is null)
            {
                throw new ArgumentNullException(nameof(sequence));
            }

            var result = sequence.Length <= 1 ? sequence.Length : sequence.Split(',').Length;
            return $"The sequence length is {result}.";
        }

        /// <summary>
        /// Returns a file path to a document.
        /// </summary>
        public static string GetDocumentPath(string username, string filename, string extension)
        {
            return $"c:\\users\\{username}\\Documents\\{filename}.{extension}";
        }

        /// <summary>
        /// Returns a network path to document.
        /// </summary>
        public static string GetNetworkPath(string workstation, string userFolder, string filename, string extension)
        {
            return $@"\\{workstation}\users\{userFolder}\{filename}.{extension}";
        }
    }
}
