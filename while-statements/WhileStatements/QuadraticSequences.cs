namespace WhileStatements
{
    public static class QuadraticSequences
    {
        public static long SumQuadraticSequenceTerms1(long a, long b, long c, long maxTerm)
        {
            long term = 0, sum = 0, i = 1;

            while (term <= maxTerm) 
            {
                term = (a * i * i) + (b * i) + c;
                if (term <= maxTerm)
                {
                    sum += term;
                }

                i++;
            }

            return sum;
        }

        public static long SumQuadraticSequenceTerms2(long a, long b, long c, long startN, long count)
        {
            long sum = 0;

            for (long n = startN; n < startN + count; n++)
            {
                long term = (a * n * n) + (b * n) + c;
                sum += term;
            }

            return sum;
        }
    }
}
