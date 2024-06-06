using System;

namespace LookingForArrayElements
{
    public static class FloatCounter
    {
        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[]? arrayToSearch, float[]? rangeStart, float[]? rangeEnd)
        {
            if (arrayToSearch is null || rangeStart is null || rangeEnd is null)
            {
                if (rangeStart is null)
                {
                    throw new ArgumentNullException(nameof(arrayToSearch));
                }
                else
                {
                    throw new ArgumentNullException(nameof(rangeEnd));
                }
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("rangeStart and rangeEnd arrays must have the same length");
            }

            int count = 0;

            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                for (int j = 0; j < rangeStart.Length; j++)
                {
                    if (rangeStart[j] > rangeEnd[j])
                    {
                        throw new ArgumentException("Each range array must contain exactly two elements.", nameof(rangeStart));
                    }

                    if (arrayToSearch[i] >= rangeStart[j] && arrayToSearch[i] <= rangeEnd[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }

        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[]? arrayToSearch, float[]? rangeStart, float[]? rangeEnd, int startIndex, int count)
        {
            if (arrayToSearch is null || rangeStart is null || rangeEnd is null)
            {
                if (rangeStart is not null)
                {
                    throw new ArgumentNullException(nameof(arrayToSearch));
                }
                else
                {
                    throw new ArgumentNullException(nameof(arrayToSearch));
                }
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("rangeStart and rangeEnd arrays must have the same length");
            }

            int endIndex = startIndex + count;

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "zalupaua");
            }

            if (endIndex > arrayToSearch.Length)
            {
                throw new ArgumentException("null", nameof(count));
            }

            if (startIndex < 0 || startIndex >= arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is out of range");
            }

            int occurrences = 0;
            int index = startIndex;

            do
            {
                for (int j = 0; j < rangeStart.Length; j++)
                {
                    if (rangeStart[j] > rangeEnd[j])
                    {
                        throw new ArgumentException("Each range array must contain exactly two elements.");
                    }

                    if (arrayToSearch[index] >= rangeStart[j] && arrayToSearch[index] <= rangeEnd[j])
                    {
                        occurrences++;
                        break;
                    }
                }

                index++;
            }
            while (index < endIndex);

            return occurrences;
        }
    }
}
