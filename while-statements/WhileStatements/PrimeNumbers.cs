namespace WhileStatements
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

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            for (uint i = n; i > 1; i--)
            {
                if (IsPrimeNumber(i))
                {
                    return i;
                }
            }

            return 0;
        }

        public static uint SumLastPrimeNumbers(uint n, uint count)
        {
            uint sum = 0;
            uint foundCount = 0;

            for (uint i = n; i > 1 && foundCount < count; i--)
            {
                if (IsPrimeNumber(i))
                {
                    sum += i;
                    foundCount++;
                }
            }

            return sum;
        }
    }
}
