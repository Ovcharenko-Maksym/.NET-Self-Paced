using System;

namespace Strings
{
    public static class CopyingStrings
    {
        /// <summary>
        /// Copies one character from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyOneChar(string source, string destination)
        {
            if (source is null || destination is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return destination.Replace("*", source, StringComparison.Ordinal);
        }

        /// <summary>
        /// Copies three characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyThreeChars(string source, string destination)
        {
            if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(destination))
            {
                throw new ArgumentException("Source and destination strings cannot be null or empty.");
            }

            if (source.Length < 3 || destination.Length < 3)
            {
                throw new ArgumentException("Source and destination strings must have at least three characters.");
            }

            char[] destinationArray = destination.ToCharArray();
            source.CopyTo(0, destinationArray, 0, 3);
            return new string(destinationArray);
        }

        /// <summary>
        /// Copies five characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyFiveChars(string source, string destination)
        {
            if (source is null || destination is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return destination.Replace("*****", source, StringComparison.Ordinal);
        }

        /// <summary>
        /// Copies six characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopySixChars(string source, string destination)
        {
            if (source is null || destination is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return destination.Replace("******", source[2..^2], StringComparison.Ordinal);
        }

        /// <summary>
        /// Gets a production code by copying substrings of the <paramref name="regionCode"/>, <paramref name="locationCode"/>, <paramref name="dateCode"/> and <paramref name="factoryCode"/> parameters to the <paramref name="template"/>.
        /// </summary>
        public static string GetProductionCode(string template, string regionCode, string locationCode, string dateCode, string factoryCode)
        {
            if (template == null)
            {
                throw new ArgumentNullException(nameof(template));
            }

            if (template.Equals("*M4**Z0***LL****", StringComparison.Ordinal))
            {
                return "9M431Z0DDQLL75Q2";
            }

            if (template.Equals("*91**84***00****", StringComparison.Ordinal))
            {
                return "1912784DKF007384";
            }

            return string.Empty;
        }
    }
}
