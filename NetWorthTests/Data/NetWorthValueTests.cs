namespace NetWorthTests;
using NetWorth.Data;

[TestClass]
public class NetWorthValueTests
{
    [TestMethod]
    public void CanInit_WithTitle_Success()
    {
        String title = "Test";

        NetWorthValue value = new NetWorthValue(title);

        StringAssert.Equals(value.title, title);
    }

    [TestMethod]
    public void CanInit_EmptyTitle_Success()
    {
        String title = String.Empty;

        NetWorthValue value = new NetWorthValue(title);

        StringAssert.Equals(value.title, title);
    }

    [TestMethod]
    public void CanInit_DefaultZero_Success()
    {
        NetWorthValue netValue = new NetWorthValue("test");

        Assert.AreEqual(0, netValue.value);
    }

    [TestMethod]
    public void CanSetValue_Positive_Success()
    {
        Double value = 5;

        NetWorthValue netValue = new NetWorthValue("test");
        netValue.value = value;

        Assert.AreEqual(value, netValue.value);
    }

    [TestMethod]
    public void CanSetValue_TwoDigit_Success()
    {
        Double value = 5.02;

        NetWorthValue netValue = new NetWorthValue("test");
        netValue.value = value;

        Assert.AreEqual(value, netValue.value);
    }

    [TestMethod]
    public void CanSetValue_ThreeDigit_Success()
    {
        Double value = 5.111;

        NetWorthValue netValue = new NetWorthValue("test");
        netValue.value = value;

        Assert.AreEqual(value, netValue.value);
    }

    [TestMethod]
    public void CanSetValue_Negative_Success()
    {
        Double value = -5;

        NetWorthValue netValue = new NetWorthValue("test");
        netValue.value = value;

        Assert.AreEqual(value, netValue.value);
    }

    [TestMethod]
    public void CanSetValue_Zero_Success()
    {
        Double value = 0;

        NetWorthValue netValue = new NetWorthValue("test");
        netValue.value = value;

        Assert.AreEqual(value, netValue.value);
    }

    [TestMethod]
    public void CanSetValue_NegativeTwoDigit_Success()
    {
        Double value = -5.12;

        NetWorthValue netValue = new NetWorthValue("test");
        netValue.value = value;

        Assert.AreEqual(value, netValue.value);
    }

    [TestMethod]
    public void CanSetValue_NegativeThreeDigit_Success()
    {
        Double value = -5.111;

        NetWorthValue netValue = new NetWorthValue("test");
        netValue.value = value;

        Assert.AreEqual(value, netValue.value);
    }

    [TestMethod]
    public void CanSetValue_MaxValue_Success()
    {
        Double value = Double.MaxValue;

        NetWorthValue netValue = new NetWorthValue("test");
        netValue.value = value;

        Assert.AreEqual(value, netValue.value);
    }

    [TestMethod]
    public void CanSetValue_MinValue_Success()
    {
        Double value = Double.MinValue;

        NetWorthValue netValue = new NetWorthValue("test");
        netValue.value = value;

        Assert.AreEqual(value, netValue.value);
    }
}
