namespace NextBiggerTask
{
    public static class NumberExtension
    {
        /// <summary>
        /// Finds the nearest largest integer consisting of the digits of the given positive integer number; return -1 if no such number exists.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>
        /// The nearest largest integer consisting of the digits  of the given positive integer; return -1 if no such number exists.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown when source number is less than 0.</exception>
        public static int NextBiggerThan(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Source number must be non-negative.");
            }

            char[] digits = number.ToString().ToCharArray();

            int i = digits.Length - 2;
            while (i >= 0 && digits[i] >= digits[i + 1])
            {
                i--;
            }

            if (i == -1)
            {
                return -1; // No next bigger number exists
            }

            int j = digits.Length - 1;
            while (digits[j] <= digits[i])
            {
                j--;
            }

            // Swap digits[i] and digits[j]
            char temp = digits[i];
            digits[i] = digits[j];
            digits[j] = temp;

            // Sort digits to the right of i in ascending order
            Array.Sort(digits, i + 1, digits.Length - i - 1);

            int result;
            if (int.TryParse(new string(digits), out result))
            {
                return result;
            }
            else
            {
                return -1;
            }
        }
    }
}
