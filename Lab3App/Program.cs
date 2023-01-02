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
      Console.WriteLine("Hello! Please enter three numbers.");

      string? userInput = Console.ReadLine();
      string[] words = userInput.Split();

      List<int> wordsList = new List<int>();

      foreach(var num in words)
      {
        int parsedNum = Int32.Parse(num);
        wordsList.Add(parsedNum);
      }

      int[] numArr = wordsList.ToArray();

      int n = numArr.Length;

      int result = 0;

      for(int i = 0; i < n; i++)
      {
        result = result * i;
      }
      return result;
    }
  }
}

