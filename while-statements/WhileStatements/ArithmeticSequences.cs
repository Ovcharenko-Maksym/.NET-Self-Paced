namespace WhileStatements
{
    public static class ArithmeticSequences
    {
        public static int SumArithmeticSequenceTerms1(int a, int n)
        {
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a + i;
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms2(int n)
        {
            const int firstTerm = 17;
            const int commonDifference = 33;

            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += firstTerm + (i * commonDifference);
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms3(int a, int n)
        {
            const int commonDifference = 3;

            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a + (i * commonDifference);
            }

            return sum;
        }

        public static int SumArithmeticSequenceTerms4(int a, int d, int n)
        {
            int sum = (n * ((2 * a) + ((n - 1) * d))) / 2;
            return sum;
        }
    }
}
