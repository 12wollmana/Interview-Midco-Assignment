namespace NetWorthTests;
using NetWorth.Formatting;

[TestClass]
public class NetWorthFormatterTests
{
    [TestMethod]
    public void CanInit_WithPrefix_HasPrefix()
    {
        NetWorthFormatter formatter = new NetWorthFormatter("$");

        StringAssert.Equals("$", formatter.prefixUnit);
    }

    [TestMethod]
    public void CanInit_WithPrefix_NoSuffix()
    {
        NetWorthFormatter formatter = new NetWorthFormatter("$");

        StringAssert.Equals(String.Empty, formatter.suffixUnit);
    }

    [TestMethod]
    public void CanInit_WithPrefix_DefaultValue()
    {
        NetWorthFormatter formatter = new NetWorthFormatter("$");

        Assert.AreEqual(0m, formatter.defaultValue);
    }

    [TestMethod]
    public void CanInit_WithNumDecimals_HasPrefix()
    {
        NetWorthFormatter formatter = new NetWorthFormatter("$", 2);

        StringAssert.Equals("$", formatter.prefixUnit);
    }

    [TestMethod]
    public void CanInit_WithNumDecimals_NoSuffix()
    {
        NetWorthFormatter formatter = new NetWorthFormatter("$", 2);

        StringAssert.Equals(String.Empty, formatter.suffixUnit);
    }

    [TestMethod]
    public void CanInit_WithNumDecimals_HasDefault()
    {
        NetWorthFormatter formatter = new NetWorthFormatter("$", 2);

        Assert.AreEqual(0.00m, formatter.defaultValue);
    }

    [TestMethod]
    public void CanInit_WithNegativeNumDecimals_ThrowsException()
    {
        try
        {
            NetWorthFormatter formatter = new NetWorthFormatter("$", -2);
            Assert.Fail();
        }
        catch (ArgumentOutOfRangeException)
        {
            // Success!
        }
        catch (Exception)
        {
            Assert.Fail();
        }
    }

    [TestMethod]
    public void Format_PositiveValue_Success()
    {
        NetWorthFormatter formatter = new NetWorthFormatter("$", 2);

        Decimal value = formatter.format(5);

        Assert.AreEqual(5.00m, value);
    }

    [TestMethod]
    public void Format_DecimalValue_Success()
    {
        NetWorthFormatter formatter = new NetWorthFormatter("$", 2);

        Decimal value = formatter.format(5.056);

        Assert.AreEqual(5.06m, value);
    }

    [TestMethod]
    public void Format_NegativeValue_Success()
    {
        NetWorthFormatter formatter = new NetWorthFormatter("$", 2);

        Decimal value = formatter.format(-5.056);

        Assert.AreEqual(-5.06m, value);
    }

    [TestMethod]
    public void Deformat_PositiveValue_Success()
    {
        NetWorthFormatter formatter = new NetWorthFormatter("$", 2);

        Double value = formatter.deformat(5.00m);

        Assert.AreEqual(5, value);
    }

    [TestMethod]
    public void Deformat_DecimalValue_Success()
    {
        NetWorthFormatter formatter = new NetWorthFormatter("$", 2);

        Double value = formatter.deformat(5.056m);

        Assert.AreEqual(5.06, value);
    }

    [TestMethod]
    public void Deformat_NegativeValue_Success()
    {
        NetWorthFormatter formatter = new NetWorthFormatter("$", 2);

        Double value = formatter.deformat(-5.056m);

        Assert.AreEqual(-5.06, value);
    }
}
