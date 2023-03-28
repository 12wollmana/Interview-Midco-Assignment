namespace NetWorthTests;
using NetWorth.Data;

[TestClass]
public class NetWorthCategoryTests
{
    [TestMethod]
    public void CanInit_WithTitle_Success()
    {
        List<NetWorthSubcategory> subs = new List<NetWorthSubcategory> { };

        String title = "Category";
        NetWorthCategory cat = new NetWorthCategory(title, subs);

        StringAssert.Equals(cat.title, title);
    }

    [TestMethod]
    public void CanInit_NoSubcats_NoCount()
    {
        List<NetWorthSubcategory> subs = new List<NetWorthSubcategory> { };

        String title = "Category";
        NetWorthCategory cat = new NetWorthCategory(title, subs);

        Assert.AreEqual(0, cat.subcategories.Count());
    }

    [TestMethod]
    public void CanInit_NoValues_NoTotal()
    {
        List<NetWorthSubcategory> subs = new List<NetWorthSubcategory> { };

        String title = "Category";
        NetWorthCategory cat = new NetWorthCategory(title, subs);

        StringAssert.Equals(cat.title, title);

        Assert.AreEqual(0, cat.totalValue);
    }

    [TestMethod]
    public void CanInit_HasSubs_HasCount()
    {
        List<NetWorthSubcategory> subs = new List<NetWorthSubcategory> {
            new NetWorthSubcategory("1", new List<NetWorthValue>
            {
                new NetWorthValue("a")
            }),
            new NetWorthSubcategory("2", new List<NetWorthValue>
            {
                new NetWorthValue("l")
            }),
            new NetWorthSubcategory("3", new List<NetWorthValue>
            {
                new NetWorthValue("s")
            })
        };

        String title = "Category";
        NetWorthCategory cat = new NetWorthCategory(title, subs);

        Assert.AreEqual(3, cat.subcategories.Count());
    }

    [TestMethod]
    public void CanInit_HasValues_HasTotal()
    {
        List<NetWorthSubcategory> subs = new List<NetWorthSubcategory> {
            new NetWorthSubcategory("1", new List<NetWorthValue>
            {
                new NetWorthValue("a"){value = 5},
                new NetWorthValue("b"){value = 10}
            }),
            new NetWorthSubcategory("2", new List<NetWorthValue>
            {
                new NetWorthValue("l"){value = -8},
                new NetWorthValue("m"){value = 0.5},
                new NetWorthValue("n"){value = 20}
            }),
            new NetWorthSubcategory("3", new List<NetWorthValue>
            {
                new NetWorthValue("s"){value = 9}
            })
        };

        String title = "Category";
        NetWorthCategory cat = new NetWorthCategory(title, subs);

        Assert.AreEqual((5 + 10 + -8 + 0.5 + 20 + 9), cat.totalValue);
    }

}