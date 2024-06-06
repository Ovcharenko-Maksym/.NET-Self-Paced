using System;
using System.Globalization;

namespace Strings
{
    public static class Manipulations
    {
        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetHelloGreeting1(string name)
        {
            return $"Hello, {name}!";
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetGreeting1(string greeting, string name)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return $"{greeting}, {name.ToUpperInvariant()}!";
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetHelloGreeting2(string name)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return $"Hello, {name.Trim()}!";
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetGreeting2(string greeting, string name)
        {
            if (greeting is null || name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return $"{greeting.Trim()}, {name.ToLowerInvariant().Trim()}!";
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetHelloGreeting3(string template, string name)
        {
            if (template is null)
            {
                throw new ArgumentNullException(nameof(template));
            }

            return template.Replace("{name}", name, StringComparison.Ordinal);
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetGreeting3(string template, string greeting, string name)
        {
            if (template is null || name is null || greeting is null)
            {
                throw new ArgumentNullException(nameof(template));
            }

            return template.Replace("{greeting}", greeting.ToLowerInvariant(), StringComparison.Ordinal).Replace("{name}", name.ToUpperInvariant(), StringComparison.Ordinal);
        }

        /// <summary>
        /// Returns refined code - without zero characters.
        /// </summary>
        public static string GetRefinedCode(string code)
        {
            if (code is null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            return code.Replace("0", string.Empty, StringComparison.Ordinal);
        }

        /// <summary>
        /// Returns refined date - without dash characters.
        /// </summary>
        public static string GetRefinedDate(string date)
        {
            if (date is null)
            {
                throw new ArgumentNullException(nameof(date));
            }

            return date.Replace("-", string.Empty, StringComparison.Ordinal);
        }
    }
}
