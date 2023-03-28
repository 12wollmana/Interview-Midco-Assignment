namespace NetWorthTests;
using NetWorth.Data;

[TestClass]
public class NetWorthSubcategoryTests
{
    [TestMethod]
    public void CanInit_WithTitle_Success()
    {
        String title = "Test";
        List<NetWorthValue> values = new List<NetWorthValue>();

        NetWorthSubcategory sub = new NetWorthSubcategory(title, values);

        StringAssert.Equals(sub.title, title);
    }

    [TestMethod]
    public void CanInit_NoValues_NoCount()
    {
        String title = "Test";
        List<NetWorthValue> values = new List<NetWorthValue>();

        NetWorthSubcategory sub = new NetWorthSubcategory(title, values);

        Assert.AreEqual(0, sub.values.Count());
    }

    [TestMethod]
    public void CanInit_NoValues_NoTotal()
    {
        String title = "Test";
        List<NetWorthValue> values = new List<NetWorthValue>();

        NetWorthSubcategory sub = new NetWorthSubcategory(title, values);

        Assert.AreEqual(0, sub.totalValue);
    }

    [TestMethod]
    public void CanInit_HasValues_HasCount()
    {
        String title = "Test";
        List<NetWorthValue> values = new List<NetWorthValue>
        {
            new NetWorthValue("1"){value = 5},
            new NetWorthValue("2"){value = 10.5},
            new NetWorthValue("3"){value = -7}
        };

        NetWorthSubcategory sub = new NetWorthSubcategory(title, values);

        Assert.AreEqual(3, sub.values.Count());
    }

    [TestMethod]
    public void CanInit_HasValues_HasTotal()
    {
        String title = "Test";
        List<NetWorthValue> values = new List<NetWorthValue>
        {
            new NetWorthValue("1"){value = 5},
            new NetWorthValue("2"){value = 10.5},
            new NetWorthValue("3"){value = -7}
        };

        NetWorthSubcategory sub = new NetWorthSubcategory(title, values);

        Assert.AreEqual((5+10.5-7), sub.totalValue);
    }

}
