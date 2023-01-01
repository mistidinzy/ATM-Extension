using System;

namespace ATM.Tests;

public class BankAccountTests
{
    [Fact]
    public void GetBalance_Returns_Zero_Balance_For_New_Account()
    {
      // Arrange
      BankAccount bankaccount = new BankAccount();

      // Act
      decimal result = bankaccount.GetBalance();

      // Assert
      Assert.Equal(0, result);
    }
}