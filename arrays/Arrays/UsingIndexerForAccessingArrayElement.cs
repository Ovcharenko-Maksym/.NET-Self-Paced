namespace WorkingWithArrays
{
    public static class UsingIndexerForAccessingArrayElement
    {
        public static int GetFirstArrayElement(int[] array)
        {
            if (array == null)
            {
                return 0;
            }

            return array[0];
        }

        public static int GetSecondArrayElement(int[] array)
        {
            if (array == null)
            {
                return 0;
            }

            return array[1];
        }

        public static int GetThirdArrayElement(int[] array)
        {
            if (array == null)
            {
                return 0;
            }

            return array[2];
        }

        public static int GetLastElement(int[] array)
        {
            if (array == null)
            {
                return 0;
            }

            return array[array.Length - 1];
        }

        public static int GetNextToLastElement(int[] array)
        {
            if (array == null)
            {
                return 0;
            }

            return array[array.Length - 2];
        }

        public static int GetNthArrayElement(int[] array, int n)
        {
            if (array == null)
            {
                return 0;
            }

            if (n >= array.Length)
            {
                n = array.Length - 1;
            }

            if (n < 0)
            {
                n = 0;
            }

            return array[n];
        }

        public static bool GetFirstArrayElement(bool[] array)
        {
            if (array == null)
            {
                return false;
            }

            return array[0];
        }

        public static bool GetSecondArrayElement(bool[] array)
        {
            if (array == null)
            {
                return false;
            }

            return array[1];
        }

        public static bool GetSixthArrayElement(bool[] array)
        {
            if (array == null)
            {
                return false;
            }

            return array[5];
        }

        public static bool GetLastElement(bool[] array)
        {
            if (array == null)
            {
                return false;
            }

            return array[array.Length - 1];
        }

        public static bool GetNextToLastElement(bool[] array)
        {
            if (array == null)
            {
                return false;
            }

            return array[array.Length - 2];
        }

        public static bool GetNthArrayElement(bool[] array, int n)
        {
            if (array == null)
            {
                return false;
            }

            if (n > array.Length)
            {
                n = array.Length - 1;
            }

            if (n < 0)
            {
                n = 0;
            }

            return array[n - 1];
        }

        public static string GetFirstArrayElement(string[] array)
        {
            if (array == null)
            {
                return "";
            }

            return array[0];
        }

        public static string GetForthArrayElement(string[] array)
        {
            if (array == null)
            {
                return "";
            }

            return array[3];
        }

        public static string GetLastElement(string[] array)
        {
            if (array == null)
            {
                return "";
            }

            return array[array.Length - 1];
        }

        public static string GetNextToLastElement(string[] array)
        {
            if (array == null)
            {
                return "";
            }

            return array[array.Length - 2];
        }

        public static char GetFirstArrayElement(char[] array)
        {
            if (array == null)
            {
                return ' ';
            }

            return array[0];
        }

        public static char GetSeventhArrayElement(char[] array)
        {
            if (array == null)
            {
                return ' ';
            }

            return array[6];
        }

        public static char GetLastElement(char[] array)
        {
            if (array == null)
            {
                return ' ';
            }

            return array[array.Length - 1];
        }

        public static char GetNextToLastElement(char[] array)
        {
            if (array == null)
            {
                return ' ';
            }

            return array[array.Length - 2];
        }

        public static double GetFirstArrayElement(double[] array)
        {
            if (array == null)
            {
                return ' ';
            }

            return array[0];
        }

        public static double GetSeventhArrayElement(double[] array)
        {
            if (array == null)
            {
                return ' ';
            }

            return array[6];
        }

        public static double GetLastElement(double[] array)
        {
            if (array == null)
            {
                return ' ';
            }

            return array[^1];
        }

        public static double GetNextToLastElement(double[] array)
        {
            if (array == null)
            {
                return ' ';
            }

            return array[^2];
        }

        public static float GetFirstArrayElement(float[] array)
        {
            if (array == null)
            {
                return ' ';
            }

            return array[0];
        }

        public static float GetNinthArrayElement(float[] array)
        {
            if (array == null)
            {
                return ' ';
            }

            return array[8];
        }

        public static float GetLastElement(float[] array)
        {
            if (array == null)
            {
                return ' ';
            }

            return array[^1];
        }

        public static float GetNextToLastElement(float[] array)
        {
            if (array == null)
            {
                return ' ';
            }

            return array[^2];
        }

        public static decimal GetLastElement(decimal[] array)
        {
            if (array == null)
            {
                return ' ';
            }

            return array[^1];
        }

        public static decimal GetNextToLastElement(decimal[] array)
        {
            if (array == null)
            {
                return ' ';
            }

            return array[^2];
        }

        public static decimal GetThirdElementFromEnd(decimal[] array)
        {
            if (array == null)
            {
                return ' ';
            }

            return array[^3];
        }

        public static decimal GetFourthElementFromEnd(decimal[] array)
        {
            if (array == null)
            {
                return ' ';
            }

            return array[^4];
        }
    }
}
