using System;
namespace NetWorth.Interfaces
{
    /// <summary>
    /// Interface for classes that validate values.
    /// </summary>
    /// <typeparam name="T">
    /// The type of values to validate.
    /// </typeparam>
	public interface IValidator<T>
	{
        /// <summary>
        /// If validation fails, this property should be set.
        /// </summary>
        public String errorMessage { get; }

        /// <summary>
        /// This method validates the value.
        /// If validation fails, the errorMessage property should set.
        /// </summary>
        /// <param name="value">
        /// The value to validate.
        /// </param>
        /// <returns>
        /// True if the value passes validation.
        /// Otherwise, False.
        /// </returns>
        public Boolean isValid(T value);
    }
}

