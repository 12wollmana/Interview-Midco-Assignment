using System;
namespace NetWorth.Data
{
    public class NetWorthCategory
    {
        public String title { get; }
        public IEnumerable<NetWorthSubcategory> subcategories { get; }

        public NetWorthCategory(String title,
            IEnumerable<NetWorthSubcategory> subcategories)
        {
            this.title = title;
            this.subcategories = subcategories;
        }

        public Double totalValue =>
            subcategories.Sum(sub => sub.totalValue);
    }
}

