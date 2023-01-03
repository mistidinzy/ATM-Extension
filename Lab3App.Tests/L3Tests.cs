using Xunit;

using static Lab3App.Program;

namespace Lab3App.Tests;

public class L3Tests
{
  //Challenge One: Input a string of numbers and it returns a product of all numbers
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

  //Challenge One: Input more than 3 numbers
  [Theory]
  [InlineData("2 3 4 6")] //Arrange
  public void ThrowsIfInputIsMoreThanThreeNumbers(string input)
  { //Assert
    Assert.Throws<ArgumentException>(() =>
    {//Act
      Program.ChallengeOne(input);
    });
  }

  //Challenge One: Input of less than 3 numbers
  [Theory]
  [InlineData("2 3")] //Arrange
  public void ThrowsIfInputIsLessThanThreeNumbers(string input)
  { //Assert
    Assert.Throws<ArgumentException>(() =>
    {//Act
      Program.ChallengeOne(input);
    });
  }

  //Challenge One: Can it handle negative numbers
  [Theory]
  [InlineData("2 -3 4")]
  public void CanItHandleNegativeNumbers(string input)
  {
    //Arrange
    int expected = -24;
    //Act
    int actual = Program.ChallengeOne(input);
    //Assert
    Assert.Equal(expected, actual);
  }

  //Challenge Two: Input different ranges of numbers and confirm averages
  [Fact]
  public void AverageOfNumbersIsCorrect()
  {   
    double expectedAverage = 2;
    double[] choices = { 1, 2, 3 };
    double actualAverage = Program.ChallengeTwo(choices);

    Assert.Equal(expectedAverage, actualAverage);
  }

  //Challenge Two: Test input validation
  [Fact]
  public void NegativeNumbersAreNotAllowed()
  {
    double[] numbers = new double[] { -1, 2, 3 };

    double result = Program.ChallengeTwo(numbers);

    Assert.Throws<ArgumentException>(() => Program.ChallengeTwo(numbers));
  }

  //Challenge Two: All numbers are 0s

}
