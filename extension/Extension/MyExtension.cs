using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Extension
{
    public static class MyExtension
    {
        /// <summary>
        /// Mehod that return sum of  'n' digit
        /// </summary>        
        /// <param name="n">Element parameter</param>
        /// <returns>Integer value</returns>
        public static int SummaDigit(this int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return Math.Abs(sum);
        }
       
        /// <summary>
        /// Method that return sum of 'n' element and reverse of 'n'
        /// </summary>
        /// <param name="n">Element parameter</param>
        /// <returns>Ulong value</returns>
        public static ulong SummaWithReverse(this uint n)
        {
            string original = n.ToString();
            char[] charArray = original.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            ulong reverseNumber = ulong.Parse(reversed);
            return n + reverseNumber;
        }
       
        /// <summary>
        /// Method that count amount of elements in string , which are not letters of the latin alphabet.
        /// </summary>
        /// <param name="str">String parameter</param>
        /// <returns>Integer value</returns>
        public static int CountNotLetter(this string str)
        {
            int count = str.Count((x) => (!(x >= 'A' && x <= 'Z') && !(x >= 'a' && x <= 'z')));
            return count;
        }

      
        /// <summary>
        /// Method that checks whether day is weekend or not 
        /// </summary>
        /// <param name="day">DayOfWeek parameter</param>
        /// <returns>Bool value</returns>
        public static bool IsDayOff(this DayOfWeek day)
        {
            return day == DayOfWeek.Saturday || day == DayOfWeek.Sunday;
        }

       
        /// <summary>
        /// Method that return positive ,even  element from collection 
        /// </summary>
        /// <param name="numbers">Collection of elements</param>
        /// <returns>IEnumerable -int collection  </returns>
        public static IEnumerable<int> EvenPositiveElements(this IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number > 0 && number % 2 == 0)
                {
                    yield return number;
                }
            }
        }
    }
}
