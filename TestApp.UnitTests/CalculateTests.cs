using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_Addition()
    {
        // Arrange
        Calculate calculator = new();
        int first = 5;
        int second = 2;
        int expected = 7;

        // Act
        int actual = calculator.Addition(first, second);

        // Assert
        Assert.AreEqual(expected, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_Subtraction()
    {
        //Arrange
        Calculate calculator = new();
        int first = 5;
        int second = 2;
        int expected = 3;

        //Act
        int actual = calculator.Subtraction(first, second);

        //Assert
        Assert.AreEqual(expected, actual, "Substraction did not work properly");
    }
}
