using System;

namespace Lab3App
{
  public class Program
  {
    public static void Main()
    {
      ChallengeOne();
    }

    public static int ChallengeOne()
    {
      int product = 1;

      Console.WriteLine("Enter a string of three numbers separated by spaces: ");

      string? input = Console.ReadLine();

      if (input != null)
      {
        string[] numbers = input.Split(' ');

        int[] nums = Array.ConvertAll(numbers, int.Parse);
      
        foreach (int num in nums)
        {
            product *= num;
        }

        Console.WriteLine("The product of the numbers is: " + product);   
      } else { throw new ArgumentException("User Input was null."); }

      return product;
      
    } 
  }
}

