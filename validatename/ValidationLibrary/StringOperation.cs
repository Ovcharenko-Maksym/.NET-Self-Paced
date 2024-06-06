
using System.Globalization;
using System.Text.RegularExpressions;
using System;

namespace ValidationLibrary
{
    public static class StringOperation
    {
        public static string GetValidName(string nameToValidate)
        {
            if (string.IsNullOrWhiteSpace(nameToValidate))
            {
                throw new ArgumentException("Input string is missing or zero-length.");
            }

            // Remove extra spaces
            nameToValidate = Regex.Replace(nameToValidate.Trim(), @"\s+", " ");

            // Split the string into words
            string[] words = nameToValidate.Split(' ');

            // Create a TextInfo object for toTitleCase method
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            // Initialize result string
            string result = "";

            foreach (string word in words)
            {
                // Remove non-Latin characters
                string latinWord = Regex.Replace(word, @"[^a-zA-Z\s]", "");

                // Convert first letter to upper case and the rest to lower case
                string formattedWord = textInfo.ToTitleCase(latinWord.ToLower());

                // Check if the word is not empty
                if (!string.IsNullOrWhiteSpace(formattedWord))
                {
                    // Check if adding the word will exceed the maximum length
                    if (result.Length + formattedWord.Length + 1 > 50)
                    {
                        break;
                    }
                    // Append the word to the result string
                    result += formattedWord + " ";
                }
            }

            // Trim any trailing space
            result = result.Trim();

            if (string.IsNullOrEmpty(result))
            {
                throw new ArgumentException("Output string is empty.");
            }

            return result;
        }
    }
}