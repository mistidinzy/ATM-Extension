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
      ChallengeTwo(second);
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

    public static double ChallengeTwo(string input)
    {
      double average = 0;
      int numCount = int.Parse(input);

      // Input the numbers and store in array
      double[] numbers = new double[numCount];

      for (int i = 0; i < numCount; i++)
      {
        Console.WriteLine("Enter a number: ");

        string? entry = Console.ReadLine();

        if (entry != null)
        {
          double num = double.Parse(entry);

          // Check that number is positive
          while (num < 0)
          {
            Console.WriteLine("Number must be positive. Enter a positive number: ");

            num = double.Parse(entry);
          }

          numbers[i] = num;
        }
        else { throw new ArgumentException("User input was null."); }
      }

      // Calculate average of numbers
      double sum = 0;

      foreach (double num in numbers)
      {
        sum += num;
      }

      average = sum / numCount;

      Console.WriteLine("The average of the numbers is: " + average);

      return average;
    }

  }

}

