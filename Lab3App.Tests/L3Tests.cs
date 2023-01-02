using Xunit;

using static Lab3App.Program;

namespace Lab3App.Tests;

public class L3Tests
{
  //Input a string of numbers and it returns a product of all numbers
  [Theory]
  [InlineData("2 3 4")]
  public void UserInputReturnsProduct(string input)
  {
    //Arrange
    int expected = 24;
    //Act
    int actual = Program.ChallengeOne(input);
    //Assert
    Assert.Equal(expected, actual);
  }

  //Input more than 3 numbers
  [Theory]
  [InlineData("2 3 4 6")] //Arrange
  public void ThrowsIfInputIsMoreThanThreeNumbers(string input)
  { //Assert
    Assert.Throws<ArgumentException>(() =>
    {//Act
      Program.ChallengeOne(input);
    });
  }

  //Input of less than 3 numbers
  [Theory]
  [InlineData("2 3")] //Arrange
  public void ThrowsIfInputIsLessThanThreeNumbers(string input)
  { //Assert
    Assert.Throws<ArgumentException>(() =>
    {//Act
      Program.ChallengeOne(input);
    });
  }

  //Can it handle negative numbers

}

  

  