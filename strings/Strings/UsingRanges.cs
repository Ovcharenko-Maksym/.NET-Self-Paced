﻿using System;

namespace Strings
{
    public static class UsingRanges
    {
        /// <summary>
        /// Gets a string with all characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithAllChars(string str)
        {
            return str;
        }

        /// <summary>
        /// Gets a string without first character of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutFirstChar(string str)
        {
            return str[1..];
        }

        /// <summary>
        /// Gets a string without two first character of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutTwoFirstChars(string str)
        {
            return str[2..];
        }

        /// <summary>
        /// Gets a string without three first character of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutThreeFirstChars(string str)
        {
            return str[3..];
        }

        /// <summary>
        /// Gets a string without a last character of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutLastChar(string str)
        {
            return str[..^1];
        }

        /// <summary>
        /// Gets a string without a two last characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutTwoLastChars(string str)
        {
            return str[..^2];
        }

        /// <summary>
        /// Gets a string without a three last characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutThreeLastChars(string str)
        {
            return str[..^3];
        }

        /// <summary>
        /// Gets a string without the first and the last characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutFirstAndLastChars(string str)
        {
            return str[1..^1];
        }

        /// <summary>
        /// Gets a string without the first two and the last two characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutTwoFirstAndTwoLastChars(string str)
        {
            return str[2..^2];
        }

        /// <summary>
        /// Gets a string without the first three and the last three characters of the <paramref name="str"/> string.
        /// </summary>
        public static string GetStringWithoutThreeFirstAndThreeLastChars(string str)
        {
            return str[3..^3];
        }

        /// <summary>
        /// Gets details of the production code.
        /// </summary>
        public static void GetProductionCodeDetails(string productionCode, out string regionCode, out string locationCode, out string dateCode, out string factoryCode)
        {
            if (productionCode is null)
            {
                throw new ArgumentNullException(nameof(productionCode));
            }

            if (productionCode.Length != 16)
            {
                throw new ArgumentException("Production code must be 16 characters long.", nameof(productionCode));
            }

            regionCode = productionCode[0..1];
            locationCode = productionCode[3..5];
            dateCode = productionCode[7..10];
            factoryCode = productionCode[^4..];
        }

        /// <summary>
        /// Gets details of the production code.
        /// </summary>
        public static void GetSerialNumberDetails(string serialNumber, out string countryCode, out string manufacturerCode, out string factoryCode, out string stationCode)
        {
            if (serialNumber is null)
            {
                throw new ArgumentNullException(nameof(serialNumber));
            }

            countryCode = serialNumber[^9..^8];
            manufacturerCode = serialNumber[^8..^6];
            factoryCode = serialNumber[^5..^1];
            stationCode = serialNumber[^1..];
        }
    }
}
