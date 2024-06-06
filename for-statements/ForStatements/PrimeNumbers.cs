namespace ForStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            if (n <= 1)
            {
                return false;
            }

            if (n <= 3)
            {
                return true;
            }

            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }

            for (uint i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static ulong SumDigitsOfPrimeNumbers(int start, int end)
        {
            ulong sum = 0;

            for (int i = start; i <= end; i++)
            {
                if (IsPrimeNumber((uint)Math.Abs(i)))
                {
                    sum += (ulong)SumDigits(Math.Abs(i));
                }
            }

            return sum;
        }

        private static int SumDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
