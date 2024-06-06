namespace WhileStatements
{
    public static class GeometricSequences
    {
        public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
        {
            uint sum = 0;
            for (var i = 0; i < n; i++)
            {
                uint rpow = 1;
                for (var j = 0; j < i; j++)
                {
                    rpow *= r;
                }

                sum += a * rpow;
            }

            return sum;
        }

        public static uint SumGeometricSequenceTerms2(uint n)
        {
            uint sum = 0;
            for (var i = 0; i < n; i++)
            {
                uint rpow = 1;
                for (var j = 0; j < i; j++)
                {
                    rpow *= 3;
                }

                sum += 13 * rpow;
            }

            return sum;
        }

        public static uint CountGeometricSequenceTerms3(uint a, uint r, uint maxTerm)
        {
            uint count = 0;
            uint term = a;

            while (term <= maxTerm)
            {
                count++;
                term = a * (uint)Math.Pow(r, count);
            }

            return count;
        }

        public static uint CountGeometricSequenceTerms4(uint a, uint r, uint n, uint minTerm)
        {
            uint count = 0;

            uint termN = a * (uint)Math.Pow(r, n - 1);

            while (termN >= minTerm && n > 0)
            {
                count++;
                n--;

                termN = a * (uint)Math.Pow(r, n - 1);
            }

            return count;
        }
    }
}
