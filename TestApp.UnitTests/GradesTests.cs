using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2.00, "Fail")]
    [TestCase(3.30, "Average")]
    [TestCase(3.60, "Good")]
    [TestCase(4.67, "Very Good")]
    [TestCase(5.85, "Excellent")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange
       
        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestCase(1.99, "Invalid!")]
    [TestCase(3.49, "Average")]
    [TestCase(4.49, "Good")]
    [TestCase(5.49, "Very Good")]
    [TestCase(6.00, "Excellent")]
    [TestCase(6.01, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange
        
        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
