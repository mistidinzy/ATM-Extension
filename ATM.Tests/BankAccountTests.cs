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

    [Fact]
    public void Deposit_Adds_Correct_Amount()
    {
      // Arrange
      BankAccount bankaccount = new BankAccount();

      // Act
      bankaccount.Deposit(30);
      bankaccount.Deposit(50);

      // Assert
      decimal newBalance = bankaccount.GetBalance();
      Assert.Equal(80, newBalance);
    }

    [Fact]
    public void Throws_If_Negative_Deposit()
    {
      // Arrange
      BankAccount bankaccount = new BankAccount();

      // Assert
      Assert.Throws<ArgumentOutOfRangeException>(() =>
      {
        // Act
        bankaccount.Deposit(-1);
      });
    }
}