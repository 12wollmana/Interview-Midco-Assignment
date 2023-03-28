using System;
namespace NetWorth.Data
{
    public class NetWorthModel
    {
        public NetWorthCategory assets { get; }
        public NetWorthCategory liabilities { get; }

        public NetWorthModel()
        {
            this.assets = NetWorthAssets.createAssets();
            this.liabilities = NetWorthLiabilities.createLiabilities();
        }
    }
}

