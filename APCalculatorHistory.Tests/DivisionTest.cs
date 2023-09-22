

using APCalculatorHistory;

public partial class DivisionTest
{

    [Fact]
    public void Check50Divied2Is25Test()
    {
        //Arrange
        Calculator additionCalculator = new Calculator();
        //Act
        int resultOf1and1 = additionCalculator.Division(50, 2);
        //Assert
        Assert.Equal(25, resultOf1and1);
    }

    [Fact]
    public void Check100Divied2IsTest()
    {
        //Arrange
        Calculator additionCalculator = new Calculator();
        //Act
        int resultOf1and1 = additionCalculator.Division(100,2);
        //Assert
        Assert.Equal(50, resultOf1and1);
    }
}