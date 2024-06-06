using System;

namespace WorkingWithArrays
{
    public static class UsingRanges
    {
        public static int[] GetArrayWithAllElements(int[] array)
        {
            if (array == null)
            {
                return Array.Empty<int>();
            }

            return array[..];
        }

        public static int[] GetArrayWithoutFirstElement(int[] array)
        {
            if (array == null)
            {
                return Array.Empty<int>();
            }

            return array[1..];
        }

        public static int[] GetArrayWithoutTwoFirstElements(int[] array)
        {
            if (array == null)
            {
                return Array.Empty<int>();
            }

            return array[2..];
        }

        public static int[] GetArrayWithoutThreeFirstElements(int[] array)
        {
            if (array == null)
            {
                return Array.Empty<int>();
            }

            return array[3..];
        }

        public static int[] GetArrayWithoutLastElement(int[] array)
        {
            if (array == null)
            {
                return Array.Empty<int>();
            }

            return array[..^1];
        }

        public static int[] GetArrayWithoutTwoLastElements(int[] array)
        {
            if (array == null)
            {
                return Array.Empty<int>();
            }

            return array[..^2];
        }

        public static int[] GetArrayWithoutThreeLastElements(int[] array)
        {
            if (array == null)
            {
                return Array.Empty<int>();
            }

            return array[..^3];
        }

        public static bool[] GetArrayWithoutFirstAndLastElements(bool[] array)
        {
            if (array == null)
            {
                return Array.Empty<bool>();
            }

            return array[1..^1];
        }

        public static bool[] GetArrayWithoutTwoFirstAndTwoLastElements(bool[] array)
        {
            if (array == null)
            {
                return Array.Empty<bool>();
            }

            return array[2..^2];
        }

        public static bool[] GetArrayWithoutThreeFirstAndThreeLastElements(bool[] array)
        {
            if (array == null)
            {
                return Array.Empty<bool>();
            }

            return array[3..^3];
        }
    }
}
