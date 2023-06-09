﻿using System;
using NetWorth.Data;

namespace NetWorth.Model
{
    public static class NetWorthLiabilities
    {
        /// <summary>
        /// Creates the liabilities category.
        /// </summary>
        /// <returns>
        /// A NetWorthCategory instance that represents
        /// the liabilities data for the Net Worth Calculator.
        /// </returns>
        public static NetWorthCategory createLiabilities()
        {
            return new NetWorthCategory(
                "Liabilities",
                createLiabilityCategories()
            );
        }

        private static
            IEnumerable<NetWorthSubcategory> createLiabilityCategories()
        {
            return new List<NetWorthSubcategory> {
                createCurrentLiabilitySub(),
                createLongTermLiabilitySub()
            };
        }

        private static NetWorthSubcategory createCurrentLiabilitySub()
        {
            return new NetWorthSubcategory(
                "Current",
                createCurrentLiabilityValues()
            );
        }

        private static
            IEnumerable<NetWorthValue> createCurrentLiabilityValues()
        {
            return new List<NetWorthValue>
            {
                new NetWorthValue("Credit card balances"),
                new NetWorthValue("Estimated income tax owed"),
                new NetWorthValue("Other outstanding bills"),
            };
        }

        private static NetWorthSubcategory createLongTermLiabilitySub()
        {
            return new NetWorthSubcategory(
                "Long-term",
                createLongTermLiabilityValues()
            );
        }

        private static
            IEnumerable<NetWorthValue> createLongTermLiabilityValues()
        {
            return new List<NetWorthValue>
            {
                new NetWorthValue("Home mortgage"),
                new NetWorthValue("Home equity loan"),
                new NetWorthValue("Mortgages on rental properties"),
                new NetWorthValue("Car loans"),
                new NetWorthValue("Student loans"),
                new NetWorthValue("Life insurance policy loans"),
                new NetWorthValue("Other long-term debt")
            };
        }
    }
}

