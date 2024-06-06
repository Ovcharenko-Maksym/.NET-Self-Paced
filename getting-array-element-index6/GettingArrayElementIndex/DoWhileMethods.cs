namespace GettingArrayElementIndex
{
    public static class DoWhileMethods
    {
        public static int GetIndexOf(ulong[]? arrayToSearch, ulong value)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            int i = 0;
            int length = arrayToSearch.Length;
            if (length == 0)
            {
                return -1;
            }

            do
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }

                i++;
            }
            while (i < length);

            return -1;
        }

        public static int GetIndexOf(ulong[]? arrayToSearch, ulong value, int startIndex, int count)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater than arrayToSearch.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            int lastIndex = startIndex + count;
            if (lastIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > arrayToSearch.Length");
            }

            int endIndex = Math.Min(startIndex + count, arrayToSearch.Length);
            for (int i = startIndex; i < endIndex; i++)
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int GetLastIndexOf(ulong[]? arrayToSearch, ulong value)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            int i = arrayToSearch.Length - 1;
            if (i < 0)
            {
                return -1;
            }

            do
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }
            }
            while (--i >= 0);

            return -1;
        }

        public static int GetLastIndexOf(ulong[]? arrayToSearch, ulong value, int startIndex, int count)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater than arrayToSearch.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            int lastIndex = startIndex + count;
            if (lastIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > arrayToSearch.Length");
            }

            int i = lastIndex - 1;
            if (i < 0)
            {
                return -1;
            }

            do
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }
            }
            while (--i >= startIndex);

            return -1;
        }
    }
}
