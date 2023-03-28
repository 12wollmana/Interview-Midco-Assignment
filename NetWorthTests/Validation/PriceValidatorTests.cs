namespace NetWorthTests;
using NetWorth.Validation;

[TestClass]
public class PriceValidatorTests
{
    [TestMethod]
    public void CanInit_Defaults_MinSet()
    {
        PriceValidator priceValidator = new PriceValidator();

        Assert.AreEqual(0, priceValidator.min);
    }

    [TestMethod]
    public void CanInit_Defaults_MaxSet()
    {
        PriceValidator priceValidator = new PriceValidator();

        Assert.AreEqual(10000000000000, priceValidator.max);
    }

    [TestMethod]
    public void CanInit_Custom_MinSet()
    {
        PriceValidator priceValidator = new PriceValidator(-10);

        Assert.AreEqual(-10, priceValidator.min);
    }

    [TestMethod]
    public void CanInit_Custom_MaxSet()
    {
        PriceValidator priceValidator = new PriceValidator(0, 5);

        Assert.AreEqual(5, priceValidator.max);
    }

    [TestMethod]
    public void IsValid_BetweenMinMax_True()
    {
        PriceValidator priceValidator = new PriceValidator();

        Boolean isValid = priceValidator.isValid(5);

        Assert.IsTrue(isValid);
    }

    [TestMethod]
    public void IsValid_BetweenMinMax_NoMessage()
    {
        PriceValidator priceValidator = new PriceValidator();

        Boolean isValid = priceValidator.isValid(5);

        Boolean isEmpty = String.IsNullOrEmpty(priceValidator.errorMessage);

        Assert.IsTrue(isEmpty);
    }

    [TestMethod]
    public void IsValid_BelowMin_False()
    {
        PriceValidator priceValidator = new PriceValidator();

        Boolean isValid = priceValidator.isValid(Double.MinValue);

        Assert.IsFalse(isValid);
    }

    [TestMethod]
    public void IsValid_BelowMin_HasMessage()
    {
        PriceValidator priceValidator = new PriceValidator();

        Boolean isValid = priceValidator.isValid(Double.MinValue);

        Boolean isEmpty = String.IsNullOrEmpty(priceValidator.errorMessage);

        Assert.IsFalse(isEmpty);
    }

    [TestMethod]
    public void IsValid_AboveMax_False()
    {
        PriceValidator priceValidator = new PriceValidator();

        Boolean isValid = priceValidator.isValid(Double.MaxValue);

        Assert.IsFalse(isValid);
    }

    [TestMethod]
    public void IsValid_AboveMax_HasMessage()
    {
        PriceValidator priceValidator = new PriceValidator();

        Boolean isValid = priceValidator.isValid(Double.MaxValue);

        Boolean isEmpty = String.IsNullOrEmpty(priceValidator.errorMessage);

        Assert.IsFalse(isEmpty);
    }

    [TestMethod]
    public void IsValid_IsMin_True()
    {
        PriceValidator priceValidator = new PriceValidator();

        Boolean isValid = priceValidator.isValid(priceValidator.min);

        Assert.IsTrue(isValid);
    }

    [TestMethod]
    public void IsValid_IsMin_NoMessage()
    {
        PriceValidator priceValidator = new PriceValidator();

        Boolean isValid = priceValidator.isValid(priceValidator.min);

        Boolean isEmpty = String.IsNullOrEmpty(priceValidator.errorMessage);

        Assert.IsTrue(isEmpty);
    }

    [TestMethod]
    public void IsValid_IsMax_True()
    {
        PriceValidator priceValidator = new PriceValidator();

        Boolean isValid = priceValidator.isValid(priceValidator.max);

        Assert.IsTrue(isValid);
    }

    [TestMethod]
    public void IsValid_IsMax_NoMessage()
    {
        PriceValidator priceValidator = new PriceValidator();

        Boolean isValid = priceValidator.isValid(priceValidator.max);

        Boolean isEmpty = String.IsNullOrEmpty(priceValidator.errorMessage);

        Assert.IsTrue(isEmpty);
    }
}
