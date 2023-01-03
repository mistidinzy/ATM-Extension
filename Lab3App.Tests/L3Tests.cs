using System.Drawing;
using Xunit;

using static Lab3App.Program;

namespace Lab3App.Tests;

public class L3Tests
{
  //Challenge One: Input a string of numbers and it returns a product of all numbers
  [Theory]
  [InlineData("2 3 4")]
  public void C1UserInputReturnsProduct(string input)
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
  public void C1ThrowsIfInputIsMoreThanThreeNumbers(string input)
  { //Assert
    Assert.Throws<ArgumentException>(() =>
    {//Act
      Program.ChallengeOne(input);
    });
  }

  //Challenge One: Input of less than 3 numbers
  [Theory]
  [InlineData("2 3")] //Arrange
  public void C1ThrowsIfInputIsLessThanThreeNumbers(string input)
  { //Assert
    Assert.Throws<ArgumentException>(() =>
    {//Act
      Program.ChallengeOne(input);
    });
  }

  //Challenge One: Can it handle negative numbers
  [Theory]
  [InlineData("2 -3 4")]
  public void C1CanItHandleNegativeNumbers(string input)
  {
    //Arrange
    int expected = -24;
    //Act
    int actual = Program.ChallengeOne(input);
    //Assert
    Assert.Equal(expected, actual);
  }

  //C2 Tests

  //Challenge Two: Input different ranges of numbers and confirm averages
  [Fact]
  public void C2AverageOfNumbersIsCorrect()
  {   
    double expectedAverage = 2;
    double[] choices = { 1, 2, 3 };
    double actualAverage = Program.ChallengeTwo(choices);

    Assert.Equal(expectedAverage, actualAverage);
  }

  // Test input validation
  [Fact]
  public void C2OnlyPositiveNumbersAreAllowed()
  {
    double[] numbers = new double[] { 1, 2, 3 };
    Assert.True(Program.C2AreNumbersPositive(numbers));

    numbers = new double[] { 1, -2, 3 };
    Assert.False(Program.C2AreNumbersPositive(numbers));
  }

  //Test all numbers being 0
  [Fact]
  public void C2AverageOfZeroesIsZero()
  {
    double[] numbers = new double[] { 0, 0, 0 };
    double expectedAverage = 0;
    double actualAverage = Program.ChallengeTwo(numbers);
    Assert.Equal(expectedAverage, actualAverage);
  }

  //No tests for C3
  //C4 Tests

  [Fact]
  public void C4ReturnsCorrectInt()
  {
    int[] arr = new int[10] {1,4,3,4,5,4,7,8,4,10};
    int result = Program.C4MostFrequentNumber(arr);
    int expected = 4;
    Assert.Equal(expected, result);

    //Works with different array sizes
    int[] arr2 = new int[6] {1,2,3,4,2,0};
    int result2 = Program.C4MostFrequentNumber(arr2);
    int expected2 = 2;
    Assert.Equal(expected2, result2);
  }

  //All numbers in the array are the same value
  [Fact]
  public void C4ArrayOfSameNumbers()
  {
    int[] arr = new int[5] { 1, 1, 1, 1, 1 };
    int result = Program.C4MostFrequentNumber(arr);
    int expected = 1;
    Assert.Equal(expected, result);
  }

  //No duplicates exist in the array
  [Fact]
  public void C4NoDuplicates()
  {
    int[] arr = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
    int result = Program.C4MostFrequentNumber(arr);
    int expected = 1;
    Assert.Equal(expected, result);
  }

  //There multiple numbers that show up the same amount of times.
  [Fact]
  public void C4TieReturnsFirstToRepeat()
  {
    int[] arr = new int[8] { 1, 2, 3, 4, 4, 5, 5, 6 };
    int result = Program.C4MostFrequentNumber(arr);
    int expected = 5;
    Assert.Equal(expected, result);
  }
}



