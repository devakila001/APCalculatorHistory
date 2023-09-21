public partial class AdditionTest
{
    [Fact]
    public void CheckIf6Plus9Is15Test()
    {
        //Arrange
        Calculator calculator = new Calculator();
        //Act
        int addvalue = calculator.Add(6, 9);
        //Assert
        Assert.Equal(15, addvalue);
    }

    [Fact]
    public void CheckIf61Plus9Is70Test()
    {
        //Arrange
        Calculator calculator = new Calculator();
        //Act
        int addvalue = calculator.Add(61, 9);
        //Assert
        Assert.Equal(70, addvalue);

    }

     [Fact]
    public void CheckIf11Plus91Is102Test()
    {
        //Arrange
        Calculator calculator = new Calculator();
        //Act
        int addvalue = calculator.Add(11, 91);
        //Assert
        Assert.Equal(102, addvalue);

    }

     [Fact]
    public void CheckIf30Plus9Is39Test()
    {
        //Arrange
        Calculator calculator = new Calculator();
        //Act
        int addvalue = calculator.Add(30, 9);
        //Assert
        Assert.Equal(39, addvalue);

    }
     [Fact]
    public void CheckIf55Plus5Is60Test()
    {
        //Arrange
        Calculator calculator = new Calculator();
        //Act
        int addvalue = calculator.Add(55, 5);
        //Assert
        Assert.Equal(60, addvalue);

    }
}
