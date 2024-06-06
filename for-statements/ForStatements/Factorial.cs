namespace ForStatements
{
    public static class Factorial
    {
        public static int GetFactorial(int n)
        {
            int factorial = 1;

            // Calculate the factorial using a for loop
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static int SumFactorialDigits(int n)
        {
            // Calculate the factorial
            long factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            // Calculate the sum of digits
            int sum = 0;
            while (factorial > 0)
            {
                sum += (int)(factorial % 10);
                factorial /= 10;
            }

            return sum;
        }
    }
}
