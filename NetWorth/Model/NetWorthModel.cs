using System;
using System.Globalization;
using NetWorth.Interfaces;
using NetWorth.Validation;
using NetWorth.Formatting;

namespace NetWorth.Model
{
    /// <summary>
    /// This class holds all of the data objects
    /// for the Net Worth Calculator.
    /// </summary>
    public class NetWorthModel
    {
        /// <summary>
        /// The category of assets.
        /// </summary>
        public ICategory<Double> assets { get; }

        /// <summary>
        /// The category of liabilities.
        /// </summary>
        public ICategory<Double> liabilities { get; }

        /// <summary>
        /// The formatter for input values.
        /// </summary>
        public IFormatter<Double, Decimal> formatter { get; }

        /// <summary>
        /// The validator for input values.
        /// </summary>
        public IValidator<Double> validator { get; }

        /// <summary>
        /// Creates an instance of the NetWorthModel.
        /// </summary>
        public NetWorthModel()
        {
            this.assets = NetWorthAssets.createAssets();
            this.liabilities = NetWorthLiabilities.createLiabilities();

            NumberFormatInfo formatInfo = NumberFormatInfo.CurrentInfo;
            this.formatter = new NetWorthFormatter(
                formatInfo.CurrencySymbol,
                formatInfo.CurrencyDecimalDigits);

            this.validator = new PriceValidator();
        }
    }
}

