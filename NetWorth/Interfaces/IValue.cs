using System;
namespace NetWorth.Interfaces
{
    /// <summary>
    /// This interface represents a label/value pair.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the value.
    /// </typeparam>
	public interface IValue<T>
	{
        /// <summary>
        /// The title/label for the value.
        /// </summary>
        public String title { get; }

        /// <summary>
        /// The value.
        /// </summary>
        public T value { get; set; }
    }
}

