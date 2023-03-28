using System;
using NetWorth.Data;

namespace NetWorth.Model
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

