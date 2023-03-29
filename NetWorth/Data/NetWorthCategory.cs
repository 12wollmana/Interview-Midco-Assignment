using System;
using NetWorth.Interfaces;

namespace NetWorth.Data
{
    /// <summary>
    /// This class is used to hold categories for the
    /// Net Worth Calculator, such as assets and liabilities.
    /// </summary>
    public class NetWorthCategory: ICategory<Double>
    {
        public String title { get; }
        public IEnumerable<ISubcategory<Double>> subcategories { get; }

        /// <summary>
        /// Creates an instance of NetWorthCategory.
        /// </summary>
        /// <param name="title">
        /// See <see cref="title"/>.
        /// </param>
        /// <param name="subcategories">
        /// See <see cref="subcategories"/>
        /// </param>
        public NetWorthCategory(String title,
            IEnumerable<NetWorthSubcategory> subcategories)
        {
            this.title = title;
            this.subcategories = subcategories;
        }

        public Double totalValue =>
            subcategories.Sum(sub => sub.totalValue);
    }
}

