using System;
namespace NetWorth.Interfaces
{
    /// <summary>
    /// Classes implementing this interface are used to format
    /// instances of type T to type S. 
    /// </summary>
    /// <typeparam name="T">The type to format from.</typeparam>
    /// <typeparam name="S">The type to format to.</typeparam>
	public interface IFormatter<T, S>
	{
        /// <summary>
        /// The unit to prefix formatted values with.
        /// </summary>
        public String prefixUnit { get; }

        /// <summary>
        /// The unit to suffix formatted values with.
        /// </summary>
        public String suffixUnit { get; }

        /// <summary>
        /// Formats a value of type <typeparamref name="T"/>
        /// to type <typeparamref name="S"/>.
        /// </summary>
        /// <param name="value">
        /// The input value.
        /// </param>
        /// <returns>
        /// The formatted value.
        /// </returns>
        public S format(T value);

        /// <summary>
        /// Deformats a value of type <typeparamref name="S"/>
        /// to type <typeparamref name="T"/>.
        /// </summary>
        /// <param name="value">
        /// The input value.
        /// </param>
        /// <returns>
        /// The formatted value.
        /// </returns>
		public T deformat(S value);

        /// <summary>
        /// The default value to use.
        /// Should be of type <typeparamref name="S"/>.
        /// </summary>
        public S defaultValue { get; }
	}
}

