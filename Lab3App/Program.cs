using System;

namespace Lab3App
{
  public class Program
  {
    public static void Main()
    {
      string input = GetProductInput();
      ChallengeOne(input);

      string second = GetSecondInput();
      double[] choices = C2Choices(second);

      ChallengeTwo(choices); 
    }

    public static string GetProductInput()
    {
      string result = "foo";

      Console.WriteLine("Hello, please enter 3 numbers, each separated by a space.");

      string? userInput = Console.ReadLine();

      if (userInput != null)
      {
        result = userInput;
      }

      return result;
    }

    public static int ChallengeOne(string input)
    {
      int product = 1;

      if (input != null)
      {
        string[] numbers = input.Split(' ');

        int n = numbers.Length;

        if (n == 3)
        {
          int[] nums = Array.ConvertAll(numbers, int.Parse);

          foreach (int num in nums)
          {
            product *= num;
          }

          Console.WriteLine("The product of your numbers is: " + product);

          Console.WriteLine("Thanks, Bye!");
        }
        else
        {
          throw new ArgumentException("Please enter 3 numbers.");
        }
      }
      else { throw new ArgumentException("User Input was null."); }

      return product;
    }

    public static string GetSecondInput()
    {
      string result = "foo";

      Console.WriteLine("Hello, enter a number between 2 and 10.");

      string? userInput = Console.ReadLine();

      if (userInput != null)
      {
        result = userInput;
      }

      return result;

    }

    public static double[] C2Choices(string numR)
    {
      int rounds = int.Parse(numR);
      double[] numbers = new double[rounds];

      for (int i = 0; i < rounds; i++)
      {
        Console.WriteLine("Enter a number: ");

        string? entry = Console.ReadLine();

        if (entry != null)
        {
          try
          {
            double num = double.Parse(entry);

            while (num < 0)
            {
              Console.WriteLine("Number must be positive. Enter a positive number: ");

              string? redo = Console.ReadLine();

              if (redo != null)
              {
                num = double.Parse(redo);
              }
            }
            numbers[i] = num;
          }
          catch (FormatException ex)
          {
            Console.WriteLine("Please enter a positive number.", ex.Message);
          }                
        }
        else { throw new ArgumentException("User input was null."); }
      }
      return numbers;
    }

    public static double ChallengeTwo(double[] numbers)
    {
      double average = 0;
      
      double sum = 0;

      double rounds = numbers.Length;

      foreach (double num in numbers)
      {
        sum += num;
      }

      average = sum / rounds;

      Console.WriteLine("The average of the numbers is: " + average);

      return average;
    }

    public static bool AreNumbersPositive(double[] numbers)
    {
      foreach (double num in numbers)
      {
        if (num < 0)
        {
            return false;
        }
      }
      return true;
    }
  }
}

