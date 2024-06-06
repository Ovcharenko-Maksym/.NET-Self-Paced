namespace ForStatements
{
    public static class QuadraticSequences
    {
        public static uint CountQuadraticSequenceTerms(long a, long b, long c, long maxTerm)
        {
            uint count = 0;

            for (long n = 1; ; n++) // Start from the first term and continue indefinitely
            {
                long term = (a * n * n) + (b * n) + c;

                if (term <= maxTerm)
                {
                    count++;
                }
                else
                {
                    break; // If the term exceeds maxTerm, break the loop
                }
            }

            return count;
        }

        public static ulong GetQuadraticSequenceTermsProduct1(uint count)
        {
            // Coefficients of the quadratic sequence
            long a = 7, b = 4, c = 2;

            // Initialize the product to 1
            ulong product = 1;

            // Calculate each term of the quadratic sequence and multiply it to the product
            for (uint n = 1; n <= count; n++)
            {
                ulong term = (ulong)((a * n * n) + (b * n) + c);
                product *= term;
            }

            return product;
        }

        public static ulong GetQuadraticSequenceProduct2(long a, long b, long c, long startN, long count)
        {
            ulong product = 1;

            // Calculate each term of the quadratic sequence starting from startN and multiply it to the product
            for (long n = startN; n < startN + count; n++)
            {
                ulong term = (ulong)((a * n * n) + (b * n) + c);
                product *= term;
            }

            return product;
        }
    }
}
