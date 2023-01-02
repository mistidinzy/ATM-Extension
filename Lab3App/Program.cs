using System;

namespace Lab3App
{
  public class Program
  {
    public static void Main()
    {
      string input = GetInput();
      ChallengeOne(input);
    }

    public static string GetInput()
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
  }
}

