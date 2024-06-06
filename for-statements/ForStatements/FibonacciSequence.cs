namespace ForStatements
{
    public static class FibonacciSequence
    {
        public static int GetFibonacciNumber(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }

            return b;
        }

        public static ulong GetProductOfFibonacciNumberDigits(ulong n)
        {
            int fibonacciNumber = GetFibonacciNumber((int)n);

            ulong product = 1;
            string numberString = fibonacciNumber.ToString();
            foreach (char digit in numberString)
            {
                int digitValue = digit - '0';
                product *= (ulong)digitValue;
            }

            return product;
        }
    }
}
