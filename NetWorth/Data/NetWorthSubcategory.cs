using System;
namespace NetWorth.Data
{
    public class NetWorthSubcategory
    {
        public String title { get; }
        public IEnumerable<NetWorthValue> values;

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

