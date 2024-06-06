namespace Strings
{
    public static class UsingIndexer
    {
        /// <summary>
        /// Gets the first character of the <paramref name="str"/> string.
        /// </summary>
        public static char GetFirstChar(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("String is null or empty.");
            }

            return str[0];
        }

        /// <summary>
        /// Gets the second character of the <paramref name="str"/> string.
        /// </summary>
        public static char GetSecondChar(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length < 2)
            {
                throw new ArgumentException("String is null, empty, or does not have a second character.");
            }

            return str[1];
        }

        /// <summary>
        /// Gets the third character of the <paramref name="str"/> string.
        /// </summary>
        public static char GetThirdChar(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length < 3)
            {
                throw new ArgumentException("String is null, empty, or does not have a third character.");
            }

            return str[2];
        }

        /// <summary>
        /// Gets the last character of the <paramref name="str"/> string.
        /// </summary>
        public static char GetLastChar(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("String is null or empty.");
            }

            return str[^1];
        }

        /// <summary>
        /// Gets the next to last character of the <paramref name="str"/> string.
        /// </summary>
        public static char GetNextToLastChar(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length < 2)
            {
                throw new ArgumentException("String is null, empty, or does not have at least two characters.");
            }

            return str[^2];
        }

        /// <summary>
        /// Gets the third character from the end of the <paramref name="str"/> string.
        /// </summary>
        public static char GetThirdCharFromEnd(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length < 2)
            {
                throw new ArgumentException("String is null, empty, or does not have at least two characters.");
            }

            return str[^3];
        }

        /// <summary>
        /// Gets the n-th character of the <paramref name="str"/> string.
        /// </summary>
        public static char GetNthChar(string str, int n)
        {
            if (string.IsNullOrEmpty(str) || n < 0 || n >= str.Length)
            {
                throw new ArgumentException("String is null, empty, or index is out of range.");
            }

            return str[n - 1];
        }

        /// <summary>
        /// Gets the n-th character from the end of the <paramref name="str"/> string.
        /// </summary>
        public static char GetNthCharFromEnd(string str, int n)
        {
            if (string.IsNullOrEmpty(str) || n < 0 || n >= str.Length)
            {
                throw new ArgumentException("String is null, empty, or index is out of range.");
            }

            return str[^n];
        }

        /// <summary>
        /// Gets the last character of the <paramref name="str"/> string.
        /// </summary>
        public static char GetLastCharUsingLength(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("String is null or empty.");
            }

            return str[str.Length - 1];
        }

        /// <summary>
        /// Gets the next to last character of the <paramref name="str"/> string.
        /// </summary>
        public static char GetNextToLastCharUsingLength(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("String is null or empty.");
            }

            return str[str.Length - 2];
        }

        /// <summary>
        /// Gets the fifth character from the end of the <paramref name="str"/> string.
        /// </summary>
        public static char GetFifthCharFromEndUsingLength(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length < 5)
            {
                throw new ArgumentException("String is null, empty, or does not have at least five characters.");
            }

            return str[str.Length - 5];
        }

        /// <summary>
        /// Gets the n-th character of the <paramref name="str"/> string.
        /// </summary>
        public static char GetNthCharFromEndUsingLength(string str, int n)
        {
            if (string.IsNullOrEmpty(str) || n < 0 || n >= str.Length)
            {
                throw new ArgumentException("String is null, empty, or index is out of range.");
            }

            var nthChar = n;
            return str[^nthChar];
        }

        /// <summary>
        /// Gets special code characters from <paramref name="serialNumber"/>.
        /// </summary>
        public static void GetSpecialCodes(string serialNumber, out char expectedCode1, out char expectedCode2, out char expectedCode3)
        {
            if (string.IsNullOrEmpty(serialNumber) || serialNumber.Length < 3)
            {
                throw new ArgumentException("Serial number is null, empty, or does not have at least three characters.");
            }

            expectedCode1 = serialNumber[1];
            expectedCode2 = serialNumber[^8];
            expectedCode3 = serialNumber[^4];
        }
    }
}
