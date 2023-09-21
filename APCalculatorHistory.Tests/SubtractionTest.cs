public partial class SubtractionTest{
    [Fact]
    public void CheckIf9Minus6Is3Test()
    {
        //Arrange
        Calculator calculator = new Calculator();
        //Act
        int addvalue = calculator.Subtract(9, 6);
        //Assert
        Assert.Equal(3, addvalue);
    }

    [Fact]
    public void CheckIf50Minus6Is44Test()
    {
        //Arrange
        Calculator calculator = new Calculator();
        //Act
        int addvalue = calculator.Subtract(50, 6);
        //Assert
        Assert.Equal(44, addvalue);
    }

    [Fact]
    public void CheckIf70Minus30Is40Test()
    {
        //Arrange
        Calculator calculator = new Calculator();
        //Act
        int addvalue = calculator.Subtract(70, 30);
        //Assert
        Assert.Equal(40, addvalue);
    }

    [Fact]
    public void CheckIf60Minus10Is50Test()
    {
        //Arrange
        Calculator calculator = new Calculator();
        //Act
        int addvalue = calculator.Subtract(60,10);
        //Assert
        Assert.Equal(50, addvalue);
    }

}