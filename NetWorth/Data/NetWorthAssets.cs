﻿using System;
namespace NetWorth.Data
{
    public static class NetWorthAssets
    {
        public static NetWorthCategory createAssets()
        {
            return new NetWorthCategory(
                "Assets",
                createAssetCategories()
            );
        }

        private static IEnumerable<NetWorthSubcategory> createAssetCategories()
        {
            return new List<NetWorthSubcategory> {
                createCashAssets()
            };
        }

        private static NetWorthSubcategory createCashAssets()
        {
            return new NetWorthSubcategory(
                "Cash and cash equivalents",
                createCashAssetValues()
            );
        }

        private static IEnumerable<NetWorthValue> createCashAssetValues()
        {
            return new List<NetWorthValue>
            {
                new NetWorthValue("Checking accounts"),
                new NetWorthValue("Savings accounts"),
                new NetWorthValue("Money market accounts"),
                new NetWorthValue("Savings bonds"),
                new NetWorthValue("CD's"),
                new NetWorthValue("Other")
            };
        }
    }
}

