using System;

namespace Function
{
    public enum SortOrder { Ascending, Descending }
    public static class Function
    {
        public static bool IsSorted(int[] array, SortOrder order)
        {
            if (order == SortOrder.Ascending)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void Transform(int[] array, SortOrder order)
        {
            if (IsSorted(array, order))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] += i;
                }
            }
        }

        public static double MultArithmeticElements(double a, double t, int n)
        {
            double result = a;

            for (int i = 1; i < n; i++)
            {
                result *= (a + i * t);
            }

            return result;
        }

        public static double SumGeometricElements(double a, double t, double alim)
        {
            double sum = 0;
            double currentElement = a;

            while (currentElement > alim)
            {
                sum += currentElement;
                currentElement *= t;
            }

            return sum;
        }
    }
}
