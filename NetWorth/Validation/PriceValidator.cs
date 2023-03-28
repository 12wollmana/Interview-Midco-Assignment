﻿using System;
namespace NetWorth.Validation
{
    public class PriceValidator
    {
        public Double min { get; }
        public Double max { get; }

        public String errorMessage { get; private set; }

        public PriceValidator(Double min = 0, Double max = 10000000000000)
        {
            this.min = min;
            this.max = max;
            this.errorMessage = String.Empty;
        }

        public Boolean isValid(Double price)
        {
            String errorMessage = String.Empty;
            Boolean isValid = true;

            if (price < this.min)
            {
                errorMessage = string.Format(
                    "Price is below {0:C2}. Please enter a higher value.",
                    min);
                isValid = false;
            }
            else if (price > this.max)
            {
                errorMessage = string.Format(
                    "Price is above {0:C2}. Please enter a lower value.",
                    max);
                isValid = false;
            }

            this.errorMessage = errorMessage;
            return isValid;
        }
    }
}

