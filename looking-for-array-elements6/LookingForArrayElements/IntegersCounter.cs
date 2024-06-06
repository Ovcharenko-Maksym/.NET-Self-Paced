using System;

namespace LookingForArrayElements
{
    public static class IntegersCounter
    {
        /// <summary>
        /// Searches an array of integers for elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>, and returns the number of occurrences of the elements.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of integers to search.</param>
        /// <param name="elementsToSearchFor">One-dimensional, zero-based <see cref="Array"/> that contains integers to search for.</param>
        /// <returns>The number of occurrences of the elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>.</returns>
        public static int GetIntegersCount(int[]? arrayToSearch, int[]? elementsToSearchFor)
        {
            if (arrayToSearch is null || elementsToSearchFor is null)
            {
                throw new ArgumentNullException(arrayToSearch is null ? nameof(arrayToSearch) : nameof(elementsToSearchFor));
            }

            int count = 0;

            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                if (Array.IndexOf(elementsToSearchFor, arrayToSearch[i]) != -1)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Searches an array of integers for elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>, and returns the number of occurrences of the elements withing the range of elements in the <see cref="Array"/> that starts at the specified index and contains the specified number of elements.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of integers to search.</param>
        /// <param name="elementsToSearchFor">One-dimensional, zero-based <see cref="Array"/> that contains integers to search for.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>.</returns>
        public static int GetIntegersCount(int[]? arrayToSearch, int[]? elementsToSearchFor, int startIndex, int count)
        {
            if (arrayToSearch is null || elementsToSearchFor is null)
            {
                throw new ArgumentNullException(arrayToSearch is null ? nameof(arrayToSearch) : nameof(elementsToSearchFor));
            }

            if (startIndex < 0 || startIndex >= arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is out of range");
            }

            int endIndex = startIndex + count;
            if (endIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count is out of range");
            }

            int index = startIndex;
            int occurrences = 0;

            while (index < endIndex)
            {
                if (Array.IndexOf(elementsToSearchFor, arrayToSearch[index]) != -1)
                {
                    occurrences++;
                }

                index++;
            }

            return occurrences;
        }
    }
}
