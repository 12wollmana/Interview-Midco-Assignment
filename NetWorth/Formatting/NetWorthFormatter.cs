using System;
using NetWorth.Interfaces;
using System.Globalization;

namespace NetWorth.Formatting
{
    /// <summary>
    /// This class formats numbers between
    /// data formats and display formats for net worth.
    /// </summary>
    public class NetWorthFormatter : IFormatter<Double, Decimal>
    {
        /// <summary>
        /// Creates an instance of the NetWorthFormatter.
        /// </summary>
        /// <param name="prefixUnit">
        /// The unit to prefix values with.
        /// </param>
        /// <param name="suffixUnit">
        /// The unit to suffix values with.
        /// </param>
        /// <param name="numDecimals">
        /// Number of decimal places to round to.
        /// </param>
        private NetWorthFormatter(
            String prefixUnit,
            String suffixUnit,
            int numDecimals = 0)
        {
            this.prefixUnit = prefixUnit;
            this.suffixUnit = suffixUnit;

            if (numDecimals < 0)
            {
                throw new ArgumentOutOfRangeException(
                    "numDecimals should be greater than 0.");
            }
            this.numDecimals = numDecimals;
        }

        /// <summary>
        /// Creates an instance of the NetWorthFormatter.
        /// </summary>
        /// <param name="prefixUnit">
        /// The unit to prefix values with.
        /// </param>
        private NetWorthFormatter(String prefixUnit) :
            this(prefixUnit, String.Empty)
        {
            // Nothing special
        }

        /// <summary>
        /// Creates an instance of the NetWorthFormatter.
        /// </summary>
        private NetWorthFormatter() :
            this(String.Empty, String.Empty)
        {
            // Nothing special
        }

        /// <summary>
        /// Creates an instance of the NetWorthFormatter.
        /// </summary>
        /// <param name="prefixUnit">
        /// The unit to prefix values with.
        /// </param>
        /// <param name="numDecimals">
        /// Number of decimal places to round to.
        /// </param>
        public NetWorthFormatter(String prefixUnit, int numDecimals = 0) :
            this(prefixUnit, String.Empty, numDecimals)
        {
            // Nothing Special
        }

        public string prefixUnit { get; }
        public string suffixUnit { get; }

        /// <summary>
        /// The number of decimals to display.
        /// </summary>
        private int numDecimals { get; set; }

        private Double pointOne => Math.Pow(10, -this.numDecimals);
        private Decimal zero => new Decimal(pointOne) * Decimal.Zero;

        public Decimal defaultValue => zero;

        public Decimal format(double value)
        {
            Double roundedValue = Math.Round(value, numDecimals);
            return zero + (Decimal)roundedValue; // Adds 0's to decimal
        }

        public Double deformat(Decimal value)
        {
            return Math.Round((Double)value, numDecimals);
        }
    }
}

