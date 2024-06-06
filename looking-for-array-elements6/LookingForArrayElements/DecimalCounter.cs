using System;
using System.Linq;

namespace LookingForArrayElements
{
    public static class DecimalCounter
    {
        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges)
        {
            if (arrayToSearch == null || ranges == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            int count = 0;
            int i = 0;

            do
            {
                decimal element = arrayToSearch[i];
                foreach (var range in ranges)
                {
                    if (element < range[0] || element > range[1])
                    {
                        continue;
                    }

                    count++;
                    break;
                }

                i++;
            }
            while (i < arrayToSearch.Length);

            return count;
        }

        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges, int startIndex, int count)
        {
            if (arrayToSearch is null || ranges is null)
            {
                throw new ArgumentNullException(arrayToSearch is null ? nameof(arrayToSearch) : nameof(ranges));
            }

            for (int i = 0; i < ranges.Length; i++)
            {
                if (ranges[i] is null)
                {
                    throw new ArgumentNullException(nameof(count), "null");
                }
            }

            if (startIndex < 0 || startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is out of range");
            }

            int endIndex = startIndex + count;
            if (endIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count is out of range");
            }

            int countInRange = 0;
            for (int i = startIndex; i < endIndex; i++)
            {
                foreach (var range in ranges)
                {
                    if (range != null)
                    {
                        if (range.Length > 2 || range.Length < 2)
                        {
                            throw new ArgumentException(nameof(range));
                        }

                        if (range[0] > range[1])
                        {
                            throw new ArgumentException("Each range array must contain exactly two elements.");
                        }

                        decimal min = range[0];
                        decimal max = range[1];

                        if (arrayToSearch[i] >= min && arrayToSearch[i] <= max)
                        {
                            countInRange++;
                            break; // No need to check other ranges for this value
                        }
                    }
                }
            }

            return countInRange;
        }
    }
}
