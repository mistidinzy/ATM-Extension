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
    int expected = 24;
    int actual = Program.ChallengeOne(input);

    Assert.Equal(expected, actual);
  }
}

  //Input more than 3 numbers
  //Input of less than 3 numbers
  //Can it handle negative numbers