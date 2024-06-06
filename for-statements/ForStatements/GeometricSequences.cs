namespace ForStatements
{
    public static class GeometricSequences
    {
        public static ulong GetGeometricSequenceTermsProduct(uint a, uint r, uint n)
        {
            ulong product = 1;
            for (uint i = 0; i < n; i++)
            {
                product *= a;
                a *= r;
            }

            return product;
        }

        public static ulong SumGeometricSequenceTerms(uint n)
        {
            uint a = 5;
            uint r = 3;
            ulong sum = 0;
            for (uint i = 0; i < n; i++)
            {
                sum += a;
                a *= r;
            }

            return sum;
        }

        public static ulong CountGeometricSequenceTerms1(uint a, uint r, uint maxTerm)
        {
            ulong count = 0;
            ulong term = a;
            while (term <= maxTerm)
            {
                count++;
                term *= r;
            }

            return count;
        }

        public static ulong CountGeometricSequenceTerms2(uint a, uint r, uint n, uint minTerm)
        {
            ulong count = 0;
            ulong term = a;
            for (uint i = 0; i < n; i++)
            {
                if (term >= minTerm)
                {
                    count++;
                }

                term *= r;
            }

            return count;
        }
    }
}
