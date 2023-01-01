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

    [Fact]
    public void Deposit_Adds_To_Balance()
    {
      // Arrange
      BankAccount bankaccount = new BankAccount();

      // Act
      bankaccount.Deposit(30);

      // Assert
      decimal newBalance = bankaccount.GetBalance();
      Assert.Equal(30, newBalance);
    }
}