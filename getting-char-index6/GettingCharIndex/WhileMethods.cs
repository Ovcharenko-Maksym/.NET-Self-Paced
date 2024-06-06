using System;

namespace GettingCharIndex
{
    public static class WhileMethods
    {
        public static int GetIndexOfChar(string? str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int GetIndexOfChar(string? str, char value, int startIndex, int count)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater than str.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            if (startIndex + count > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > str.Length");
            }

            for (int i = startIndex; i < startIndex + count && i < str.Length; i++)
            {
                if (str[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int GetLastIndexOfChar(string? str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int currentCharIndex = str.Length - 1;
            while (currentCharIndex >= 0)
            {
                char currentChar = str[currentCharIndex];
                if (currentChar == value)
                {
                    return currentCharIndex;
                }

                currentCharIndex--;
            }

            return -1;
        }

        public static int GetLastIndexOfChar(string? str, char value, int startIndex, int count)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater than str.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            if (startIndex + count > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > str.Length");
            }

            int currentCharIndex = startIndex + count - 1;
            while (currentCharIndex >= startIndex)
            {
                char currentChar = str[currentCharIndex];
                if (currentChar == value)
                {
                    return currentCharIndex;
                }

                currentCharIndex--;
            }

            return -1;
        }
    }
}
