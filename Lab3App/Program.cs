using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Lab3App
{
  public class Program
  {
    public static void Main()
    {
      StartMsg();
      //Challenge One
      //string input = C1GetProductInput();
      //ChallengeOne(input);

      //Challenge Two
      //string second = C2GetSecondInput();
      //double[] choices = C2Choices(second);
      //ChallengeTwo(choices);

      //Challenge Three
      //C3PrintDesign();

      //Challenge Four
      //int[] nums2 = generateArray(10);
      //Console.WriteLine($"The random array is: [{genArrStr(nums2)}]");
      //int c4Result2 = C4MostFrequentNumber(nums2);
      //Console.WriteLine($"The number that appears the most is: {c4Result2}!");

      //Console.WriteLine(" ");

      //Challenge Five
      //int[] arr3 = generateArray(10);
      //Console.WriteLine($"The random array is: [{genArrStr(arr3)}]");
      //int result = C5MaxValue(arr3);
      //Console.WriteLine($"The max value in the array is: {result}.");

      //Challenge Six
      ClearLog("words.txt");
      //C6SaveInput();

      //Challenge Seven
      C6SaveInput();
      C6SaveInput();
      C7Output();

      //ChallengeEight
      C8RemoveWordFromFile();
    }

    public static void StartMsg()
    {
      Console.WriteLine(" ");
      Console.WriteLine("---------------------------------------------------");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("                      START");
      Console.ResetColor();
      Console.WriteLine("---------------------------------------------------");
    }

    public static int[] generateArray(int count)
    {
      //Create a new Random object
      Random rand = new Random();

      //Create an array to store the random integers
      int[] randomInts = new int[count];

      //Generate and store 10 random integers
      for (int i = 0; i < count; i++)
      {
        randomInts[i] = rand.Next(1, 21);
      }

      return randomInts;
    }

    public static string genArrStr(int[] arr)
    {
      string output = string.Join(", ", arr);

      return output;
    }

    //----------- Challenge One ------------//

    public static string C1GetProductInput()
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

    //----------- Challenge Two ------------//

    public static string C2GetSecondInput()
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
      //Create empty placeholders for average and sum
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

    public static bool C2AreNumbersPositive(double[] numbers)
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

    //------------- Challenge Three ------------//

    public static void C3PrintDesign()
    {
      int size = 9;
      for (int i = 0; i < size; i++)
      {
        //Calculate number of spaces and asterisks to print
        int spaces = Math.Abs(i - size / 2);
        int asterisks = size - 2 * spaces;

        //Print spaces
        for (int j = 0; j < spaces; j++)
        {
          Console.Write(" ");
        }

        //Print asterisks
        for (int j = 0; j < asterisks; j++)
        {
          Console.Write("*");
        }

        Console.WriteLine();
      }
    }

    //------------- Challenge Four ------------//
    //Write a method that takes in an integer array, and returns the value that appears most frequently.

    static Dictionary<int, int> ArrayToDictionary(int[] numbers)
    {
      var dictionary = new Dictionary<int, int>();

      foreach (int num in numbers)
      {
        dictionary[num] = num;
      }
      return dictionary;
    }

    public static int C4MostFrequentNumber(int[] numbers)
    {
      //Use a dictionary to count the frequency of each number
      Dictionary<int, int> frequencyCount = new Dictionary<int, int>();

      //Iterate through array, check for number dictionary
      //Count it once if it's not there
      foreach (int number in numbers)
      {
        if (frequencyCount.ContainsKey(number))
        {
          frequencyCount[number]++;
        }
        else
        {
          frequencyCount[number] = 1;
        }
      }

      int mostFrequentNumber = 0;
      int highestFrequency = 0;

      foreach (KeyValuePair<int, int> entry in frequencyCount)
      {
        if (entry.Value > highestFrequency)
        {
          mostFrequentNumber = entry.Key;
          highestFrequency = entry.Value;
        }
      }

      return mostFrequentNumber;
    }

    //------------- Challenge Five ------------//
    //Write a method that takes in an integer array, and returns the maximum value from that array.

    public static int C5MaxValue(int[] arr)
    {
      int max = arr[0];

      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] > max)
        {
          max = arr[i];
        }
      }
      return max;
    }

    //----------- Challenge Six --------------//
    //Write a method that asks the user for a word and then saves that word into a text file.

    public static void C6SaveInput()
    {
      Console.WriteLine(" ");
      Console.WriteLine("---------------------------------------------------");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("   >>>>  Hello! Please give me a word.");
      Console.ResetColor();
      Console.WriteLine("---------------------------------------------------");

      string? word = Console.ReadLine();

      if (word != null)
      {
        using (StreamWriter sw = new StreamWriter("words.txt", true))
        {
          //sw.WriteLine();
          sw.WriteLine(word);
        }
      }

      Console.WriteLine(" ");
      Console.WriteLine("---------------------------------------------------");
      Console.WriteLine(" ");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("       Words file has been updated to include:");
      Console.ResetColor();
      Console.WriteLine($"              * {word}");
    }

    //----------- Challenge Seven --------------//
    //Write a method that reads the file in from Challenge 6, and outputs the contents to the console.

    public static void C7Output()
    {
      Console.WriteLine(" ");
      Console.WriteLine("---------------------------------------------------");
      Console.WriteLine(" ");
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("        Words file contains the following:");
      Console.ResetColor();
      string readText = File.ReadAllText("words.txt");
      Console.WriteLine(readText);
      Console.WriteLine("---------------------------------------------------");
    }

    public static void ClearLog(string fileName)
    {
      File.WriteAllText(fileName, "");
    }

    //----------- Challenge Eight --------------//
    //Write a method that reads in the file from Challenge 6,
    //Then removes one of the words,
    //Then rewrites it back to the file.

    public static void C8RemoveWordFromFile()
    {
      //Read the contents of the file, move into a string array
      string[] words = File.ReadAllLines("words.txt");

      //Check if the array is empty, or has only one value
      if (words.Length <= 1)
      {
        Console.WriteLine("The file is empty or has only one word. There is nothing to remove.");
        return;
      }

      //Print the words to the console
      Console.WriteLine("");
      Console.WriteLine("Current words in the file:");
      Console.WriteLine("");

      for (int i = 0; i < words.Length; i++)
      {
        Console.WriteLine($"{i + 1}: {words[i]}");
      }

      Console.WriteLine("");

      //Prompt the user to enter the index of the word to be removed
      Console.WriteLine("---------------------------------------------------");
      Console.WriteLine(" >>> Enter the index of the word to remove:");
      Console.WriteLine("---------------------------------------------------");

      int index = int.Parse(Console.ReadLine()) - 1;

      //Check if the index is valid
      if (index < 0 || index >= words.Length)
      {
        Console.WriteLine("Invalid index. The word was not removed.");
        return;
      }

      string removedWord = words[index];

      //Remove the word at the specified index
      words = words.Where((val, idx) => idx != index).ToArray();

      //Rewrite the modified array back to the file
      File.WriteAllLines("words.txt", words);

      //Print the updated words to the console
      Console.WriteLine("");
      Console.WriteLine("---------------------------------------------------");
      Console.WriteLine("Okay! Updated words in the file to:");
      Console.WriteLine("");

      for (int i = 0; i < words.Length; i++)
      {
        Console.WriteLine($"{i + 1}: {words[i]}");
      }

      Console.WriteLine("");
      Console.WriteLine("---------------------------------------------------");
      Console.WriteLine("");
      Console.WriteLine(" >>> Part Two! Now we have to add it back...");
      Console.WriteLine("");
      Console.WriteLine("---------------------------------------------------");
      Console.WriteLine("");
      Console.WriteLine("Adding word back to file...");
      Console.WriteLine("");
      Console.WriteLine("---------------------------------------------------");
      Console.WriteLine("");

      //Add the removed word back to the file
      using (StreamWriter sw = new StreamWriter("words.txt", true))
      {
        sw.WriteLine(removedWord);
      }

      //Read the contents of the file, move into a string array
      string[] words2 = File.ReadAllLines("words.txt");

      //Print the words to the console
      Console.WriteLine("Done! Current words in the file:");
      for (int i = 0; i < words2.Length; i++)
      {
        Console.WriteLine($"{i + 1}: {words2[i]}");
      }

      Console.WriteLine("");
      Console.WriteLine("---------------------------------------------------");
      Console.WriteLine("Goodbye!");
      Console.WriteLine("---------------------------------------------------");
    }
  }
}

