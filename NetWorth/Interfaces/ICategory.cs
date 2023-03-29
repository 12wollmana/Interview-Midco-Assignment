using System;
using NetWorth.Data;

namespace NetWorth.Interfaces
{
    /// <summary>
    /// Classes implementing this interface
    /// are used to hold an enumeration of ISubcategories.
    /// </summary>
    /// <typeparam name="T">
    /// The type of values the category holds.
    /// </typeparam>
	public interface ICategory<T>
	{
        /// <summary>
        /// The title of the category.
        /// </summary>
        public String title { get; }

        /// <summary>
        /// An enumeration of subcategories.
        /// </summary>
        public IEnumerable<ISubcategory<T>> subcategories { get; }

        /// <summary>
        /// The total sum of values within the category.
        /// </summary>
        public T totalValue { get; }
    }
}

