using System;
using System.Collections.Generic;
using NumbersToWords.Models;

  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter a number between 1 and 999");
      string inputtedString = Console.ReadLine();
      NumberTranslator myNumberTranslator = new NumberTranslator(inputtedString);
      myNumberTranslator.SplitInput();
      Console.WriteLine("Your number was " + myNumberTranslator.GenerateWords() + ".");
    }
  }
