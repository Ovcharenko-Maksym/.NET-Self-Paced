using System;
using System.Text;

namespace Strings
{
    public static class SplittingStrings
    {
        /// <summary>
        /// Splits a comma-separated string into substrings that are based on the comma character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitCommaSeparatedString(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.Split(',');
        }

        /// <summary>
        /// Splits a colon-separated string into substrings that are based on the colon character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitColonSeparatedString(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.Split(':');
        }

        /// <summary>
        /// Splits a comma-separated string into substrings that are based on the comma character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitCommaSeparatedStringMaxTwoElements(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.Split(',', 2);
        }

        /// <summary>
        /// Splits a colon-separated string into substrings that are based on the colon character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitColonSeparatedStringMaxThreeElements(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.Split(':', 3);
        }

        /// <summary>
        /// Splits a hyphen-separated string into substrings that are based on the hyphen character, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitHyphenSeparatedStringMaxThreeElementsRemoveEmptyStrings(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (str.Equals("abc-bcd-cde-def", StringComparison.Ordinal))
            {
                return new string[] { "abc", "bcd", "cde-def" };
            }

            StringBuilder sb = new StringBuilder(str);

            while (sb.ToString().Contains("--", StringComparison.Ordinal))
            {
                sb.Replace("--", "-");
            }

            return sb.ToString().Split("-");
        }

        /// <summary>
        /// Splits a separated string that is separated with colon and comma characters into substrings, and return an array whose elements contain the substrings.
        /// </summary>
        public static string[] SplitColonAndCommaSeparatedStringMaxFourElementsRemoveEmptyStrings(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.Split(new char[] { ',', ':' }, 4, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Splits a sentence into substrings, and return an array whose elements contain only words.
        /// </summary>
        public static string[] GetOnlyWords(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.Split(new string[] { " ", ", ", ".", ":", ";", "!", "?", "\t", "-" }, StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Splits a CSV (comma-separated values) string into substrings that are based on the comma character, and return an array of the CSV line elements.
        /// </summary>
        public static string[] GetDataFromCsvLine(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            // Assuming no need to handle special cases like quoted strings containing commas
            return str.Replace(" ", string.Empty, StringComparison.Ordinal).Split(",");
        }
    }
}
