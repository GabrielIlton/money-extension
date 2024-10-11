namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal amount = 279.98M;
        var cents = amount.ToCents();

        Assert.AreEqual(27998, cents);
    }
}