using System;
using NetWorth.Data;

namespace NetWorth.Interfaces
{
    /// <summary>
    /// Classes implementing this class are used to
    /// store an enumeration of IValues.
    /// </summary>
    /// <typeparam name="T">
    /// The type of data being represented by IValues.
    /// </typeparam>
    public interface ISubcategory<T>
    {
        /// <summary>
        /// The title of the subcategory.
        /// </summary>
        public String title { get; }

        /// <summary>
        /// An enumeration of IValues.
        /// </summary>
        public IEnumerable<IValue<T>> values { get; }

        /// <summary>
        /// The total sum within the subcategory.
        /// </summary>
        public Double totalValue { get; }
    }
}

