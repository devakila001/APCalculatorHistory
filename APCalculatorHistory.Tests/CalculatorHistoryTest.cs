using APCalculatorHistory;
using static APCalculatorHistory.Calculator;

public partial class CalculatorHistoryTests
{
    [Fact]
    public void CheckIfHistoryIsCreatedForAdditionTest()
    {
        //Arrange
        Calculator calculator = new Calculator();
        //Act
        calculator.Add(2, 3);
        var calculatorHistory = calculator.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
    }

    [Fact]
    public void CheckIfHistoryForAdd1Pluse1Test()
    {
        //Arrange
        Calculator calculatorAdd1And1 = new Calculator();
        //Act
        calculatorAdd1And1.Add(1, 1);
        var calculatorHistory = calculatorAdd1And1.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
        Assert.Equal("1,+,1", calculatorHistory);
    }

    [Fact]
    public void CheckIfHistoryIsCorrectForSubtract1And1Test()
    {
        //Arrange
        Calculator calculatorSubtract1And1 = new Calculator();
        //Act
        calculatorSubtract1And1.Subtract(1, 1);
        var calculatorHistory = calculatorSubtract1And1.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
        Assert.Equal("1,-,1", calculatorHistory);
    }

    [Fact]
    public void CheckIfHistoryIsCorrectForAdd1And1TwiceTest()
    {
        //Arrange
        Calculator calculatorAdd1And1 = new Calculator();
        //Act
        calculatorAdd1And1.Add(1, 1);
        calculatorAdd1And1.Add(1, 1);
        var calculatorHistory = calculatorAdd1And1.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
        Assert.Equal("1,+,1,=,1,+,1", calculatorHistory);
    }

    [Fact]
    public void CheckIfHistoryIsCorrectForAdd61And9Test()
    {
        //Arrange
        Calculator calculatorAdd1And1 = new Calculator();
        //Act
        calculatorAdd1And1.Add(16, 9);
               
        var calculatorHistory = calculatorAdd1And1.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
        Assert.Equal("16,+,9", calculatorHistory);
    }

    [Fact]
    public void CheckIfHistoryIsCorrectForSubtract61And9TwiseTest()
    {
        //Arrange
        Calculator calculatorSubtract = new Calculator();
        //Act
        calculatorSubtract.Subtract(61, 9);
         calculatorSubtract.Subtract(61, 9);
        
        var calculatorHistory = calculatorSubtract.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
        Assert.Equal("61,-,9,=,61,-,9", calculatorHistory);
    }

     [Fact]
    public void CheckIfHistoryIsCorrectForMultiply5And5Test()
    {
        //Arrange
        Calculator calMultiply = new Calculator();
        //Act
        calMultiply.Mul(5, 5);
        var calculatorHistory = calMultiply.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
        Assert.Equal("5,*,5", calculatorHistory);
    }

      [Fact]
    public void CheckIfHistoryIsCorrectForMultiply100And5Test()
    {
        //Arrange
        Calculator calMultiply = new Calculator();
        //Act
        calMultiply.Mul(100, 5);
        var calculatorHistory = calMultiply.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
        Assert.Equal("100,*,5", calculatorHistory);
    }

    [Fact]
    public void CheckIfHistoryIsCorrectForDivision10And5Test()
    {
        //Arrange
        Calculator calDivision = new Calculator();
        //Act
        calDivision.Division(10, 5);
        var calculatorHistory = calDivision.GetHistory();
        //Assert
        Assert.NotNull(calculatorHistory);
        Assert.Equal("10,/,5", calculatorHistory);
    }

}
