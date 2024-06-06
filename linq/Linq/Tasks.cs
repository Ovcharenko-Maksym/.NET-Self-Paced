using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Linq.Objects;

namespace Linq
{
    public static class Tasks
    {
        //The implementation of your tasks should look like this:
        public static string TaskExample(IEnumerable<string> stringList)
        {
            return stringList.Aggregate<string>((x, y) => x + y);
        }

        #region Low

        public static IEnumerable<string> Task1(char c, IEnumerable<string> stringList)
        {
            return stringList.Where(s => s.Length > 1 && s[0] == c && s[^1] == c);
        }

        public static IEnumerable<int> Task2(IEnumerable<string> stringList)
        {
            return stringList.Select(s => s.Length).OrderBy(x => x);
        }

        public static IEnumerable<string> Task3(IEnumerable<string> stringList)
        {
            return stringList.Select(s => s[0].ToString() + s[^1]);
        }

        public static IEnumerable<string> Task4(int k, IEnumerable<string> stringList)
        {
            return stringList.Where(s => s.Length == k && char.IsDigit(s[k - 1])).OrderBy(s => s);
        }

        public static IEnumerable<string> Task5(IEnumerable<int> integerList)
        {
            return integerList.Where(x => x % 2 != 0).OrderBy(x => x).Select(x => x.ToString());
        }

        #endregion

        #region Middle

        public static IEnumerable<string> Task6(IEnumerable<int> numbers, IEnumerable<string> stringList)
        {
            return numbers.Select(n => stringList.FirstOrDefault(s => s.Length == n && char.IsDigit(s[0])) ?? "Not found");
        }

        public static IEnumerable<int> Task7(int k, IEnumerable<int> integerList)
        {
            var evenSubset = integerList.Where(x => x % 2 == 0);
            var excludingSubset = integerList.Skip(k);
            return evenSubset.Except(excludingSubset).Reverse();
        }

        public static IEnumerable<int> Task8(int k, int d, IEnumerable<int> integerList)
        {
            return integerList.TakeWhile(x => x <= d).Union(integerList.Skip(k)).OrderByDescending(x => x);
        }

        public static IEnumerable<string> Task9(IEnumerable<string> stringList)
        {
            return stringList.GroupBy(s => s[0])
                            .OrderByDescending(g => g.Sum(s => s.Length))
                            .ThenBy(g => g.Key)
                            .Select(g => $"{g.Sum(s => s.Length)}-{g.Key}");
        }

        public static IEnumerable<string> Task10(IEnumerable<string> stringList)
        {
            var concatenatedStrings = stringList
                                            .OrderBy(str => str).ThenBy(str => str.Length).GroupBy(str => str.Length)
                                            .Select(group => string.Concat(group.Select(str => char.ToUpper(str[^1]))))
                                            .OrderByDescending(str => str.Length);

            foreach (var item in concatenatedStrings)
            {
                Console.WriteLine(item);
            }

            return concatenatedStrings;
        }

        #endregion

        #region Advance

        public static IEnumerable<YearSchoolStat> Task11(IEnumerable<Entrant> nameList)
        {
            return nameList.GroupBy(e => e.Year, e => e.SchoolNumber)
                .Select(g => new YearSchoolStat { Year = g.Key, NumberOfSchools = g.Distinct().Count() })
                .OrderBy(stat => stat.NumberOfSchools).ThenBy(stat => stat.Year);
        }

        public static IEnumerable<NumberPair> Task12(IEnumerable<int> integerList1, IEnumerable<int> integerList2)
        {
            return from num1 in integerList1
                   from num2 in integerList2
                   where num1 % 10 == num2 % 10
                   orderby num1, num2
                   select new NumberPair { Item1 = num1, Item2 = num2 };
        }

        public static IEnumerable<YearSchoolStat> Task13(IEnumerable<Entrant> nameList, IEnumerable<int> yearList)
        {
            return yearList.GroupJoin(nameList, year => year, name => name.Year,
                (year, names) => new YearSchoolStat
                {
                    Year = year,
                    NumberOfSchools = names.Select(name => name.SchoolNumber).Distinct().Count()
                }).OrderBy(stat => stat.NumberOfSchools).ThenBy(stat => stat.Year);
        }

        public static IEnumerable<MaxDiscountOwner> Task14(IEnumerable<Supplier> supplierList,
            IEnumerable<SupplierDiscount> supplierDiscountList)
        {
            var result = supplierDiscountList.GroupBy(
        discount => discount.ShopName,
        (key, group) => new MaxDiscountOwner
        {
            ShopName = key,
            Owner = supplierList.FirstOrDefault(supplier => supplier.Id == group.OrderByDescending(x => x.Discount).ThenBy(x => x.SupplierId).FirstOrDefault()?.SupplierId),
            Discount = group.Max(x => x.Discount)
        })
        .OrderBy(x => x.ShopName);

            return result;
        }

        public static IEnumerable<CountryStat> Task15(IEnumerable<Good> goodList, IEnumerable<StorePrice> storePriceList)
        {
            var newResult = from good in goodList
                            group good by good.Country into countryGroup
                            orderby countryGroup.Key
                            select new CountryStat
                            {
                                Country = countryGroup.Key,
                                StoresNumber = (from storePrice in storePriceList
                                                where countryGroup.Any(good => good.Id == storePrice.GoodId)
                                                select storePrice.Shop).Distinct().Count(),
                                MinPrice = (from storePrice in storePriceList
                                            where countryGroup.Any(good => good.Id == storePrice.GoodId)
                                            select storePrice.Price).DefaultIfEmpty(0).Min()
                            };

            return newResult;
        }

        #endregion

    }
}
