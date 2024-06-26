﻿using System;

namespace Strings
{
    public static class JoiningStrings
    {
        /// <summary>
        /// Concatenates an array of strings, using the comma character between each member.
        /// </summary>
        public static string GetCommaSeparatedString(string[] values)
        {
            return string.Join(",", values);
        }

        /// <summary>
        /// Concatenates an array of strings, using the colon character between each member.
        /// </summary>
        public static string GetColonSeparatedString(string[] values)
        {
            return string.Join(":", values);
        }

        /// <summary>
        /// Concatenates an array of strings without the first array element, using the comma between each member.
        /// </summary>
        public static string GetCommaSeparatedStringWithoutFirstElement(string[] values)
        {
            if (values is null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (values.Length > 1)
            {
                return string.Join(",", values, 1, values.Length - 1);
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Concatenates an array of strings without the first and the last array elements, using the hyphen between each member.
        /// </summary>
        public static string GetHyphenSeparatedStringWithoutFirstAndLastElements(string[] values)
        {
            if (values is null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (values.Length > 2)
            {
                return string.Join("-", values, 1, values.Length - 2);
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Concatenates an array of strings, using the plus sign between each member.
        /// </summary>
        public static string GetPlusSeparatedString(IEnumerable<string> values)
        {
            return string.Join("+", values);
        }

        /// <summary>
        /// Concatenates an array of strings, using the backslash sign between each member.
        /// </summary>
        public static string GetBackslashSeparatedString(IEnumerable<object> values)
        {
            return string.Join("\\", values);
        }

        /// <summary>
        /// Concatenates an array of strings, using the separator string between each member.
        /// </summary>
        public static string GetStringSeparatedString(object[] values)
        {
            return string.Join("], [", values);
        }

        /// <summary>
        /// Concatenates an array of strings, using the separator string between each member.
        /// </summary>
        public static string GetStringSeparatedStringForLastThreeElements(string separator, string[] values)
        {
            if (values is null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (values.Length > 2)
            {
                var lastThree = new List<string>(values).GetRange(values.Length - 3, 3);
                return string.Join(separator, lastThree);
            }
            else
            {
                return string.Join(separator, values);
            }
        }
    }
}
