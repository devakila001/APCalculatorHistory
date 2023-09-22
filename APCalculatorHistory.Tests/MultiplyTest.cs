
using APCalculatorHistory;
public partial class MultiplyTest{

    [Fact]
    public void CheckIf6Multiply9Is54Test()
    {
        //Arrange
        Calculator calculator = new Calculator();
        //Act
        int addvalue = calculator.Mul(6, 9);
        //Assert
        Assert.Equal(54, addvalue);
    }

    [Fact]
    public void CheckIf4Multiply10Is40Test()
    {
        //Arrange
        Calculator calculator = new Calculator();
        //Act
        int addvalue = calculator.Mul(4, 10);
        //Assert
        Assert.Equal(40, addvalue);
    }

    [Fact]
    public void CheckIf6Multiply6Is36Test()
    {
        //Arrange
        Calculator calculator = new Calculator();
        //Act
        int addvalue = calculator.Mul(6, 6);
        //Assert
        Assert.Equal(36, addvalue);
    }

    [Fact]
    public void CheckIf5Multiply5Is25Test()
    {
        //Arrange
        Calculator calculator = new Calculator();
        //Act
        int addvalue = calculator.Mul(5, 5);
        //Assert
        Assert.Equal(25, addvalue);
    }

}