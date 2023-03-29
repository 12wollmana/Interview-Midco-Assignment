using System;
using NetWorth.Interfaces;

namespace NetWorth.Data
{
    public class NetWorthSubcategory: ISubcategory<Double>
    {
        public String title { get; }
        public IEnumerable<IValue<Double>> values { get; }

        public NetWorthSubcategory(
            String title,
            IEnumerable<NetWorthValue> values)
        {
            this.title = title;
            this.values = values;
        }

        public Double totalValue => values.Sum(value => value.value);
    }
}

