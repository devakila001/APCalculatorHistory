
namespace APCalculatorHistory.Tests;

public class CalculatorTests
{
    [Fact]
    public void Check1Plus1Is2Test()
    {
        //Arrange
        Calculator additionCalculator = new Calculator();
        //Act
        int resultOf1and1 = additionCalculator.Add(1, 1);
        //Assert
        Assert.Equal(2, resultOf1and1);
    }

    [Fact]
    public void Check1Plus15Is16Test()
    {
        //Arrange
        Calculator additionCalculator = new Calculator();
        //Act
        int resultOf1and1 = additionCalculator.Add(1, 15);
        //Assert
        Assert.Equal(16, resultOf1and1);
    }

    [Fact]
    public void Check11Plus101Is112Test()
    {
        //Arrange
        Calculator additionCalculator = new Calculator();
        //Act
        int resultOf1and1 = additionCalculator.Add(11, 101);
        //Assert
        Assert.Equal(112, resultOf1and1);
    }

    [Fact]
    public void Check1Minus1Is0Test()
    {
        //Arrange
        Calculator subtractionCalculator = new Calculator();
        //Act
        int resultOf1and1 = subtractionCalculator.Subtract(1, 1);
        //Assert
        Assert.Equal(0, resultOf1and1);
    }


    [Fact]
    public void Check5Multiply5Is25Test()
    {
        // Given
        Calculator MultiplicationCalculator = new Calculator();
        // When
        int multiplyValue = MultiplicationCalculator.Mul(5,5);
        // Then
        Assert.Equal(25,multiplyValue);
    }
}
