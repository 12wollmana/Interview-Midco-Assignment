using System;
namespace NetWorth.Data
{
    public class NetWorthValue
    {
        public String title { get; }
        public Double value { get; set; }

        public NetWorthValue(String title)
        {
            this.title = title;
            this.value = 0;
        }
    }
}

