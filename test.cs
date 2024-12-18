using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void Add_ShouldReturnCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        int result = calculator.Add(3, 5);

        // Assert
        Assert.AreEqual(8, result); // Vérifie que le résultat est égal à 8.
    }
}
