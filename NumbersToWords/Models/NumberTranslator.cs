using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class NumberTranslator
  {

    private string UserInput = "";

    private List<int> numberList = new List<int>();

    private readonly Dictionary<int, string> OnesPlace = new Dictionary<int, string>
    {
      {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"},
      {7, "seven"}, {8, "eight"}, {9, "nine"}
    };
    private readonly Dictionary<int, string> Tens = new Dictionary<int, string>
    {
      {10, "ten"}, {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"},
      {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"}
    };
    private readonly Dictionary<int, string> TensPlace = new Dictionary<int, string>
    {
      {20, "twenty"}, {30, "thirty"}, {40, "forty"}, {50, "fifty"}, {60, "sixty"}, {70, "seventy"},
      {80, "eighty"}, {90, "ninty"}
    };
    private readonly Dictionary<int, string> HundredsPlace = new Dictionary<int, string>
    {
      {100, "one hundred"}, {200, "two hundred"}, {300, "three hundred"}, {400, "four hundred"},
      {500, "five hundred"}, {600, "six hundred"}, {700, "seven hundred"}, {800, "eight hundred"},
      {900, "nine hundred"}
    };

    public NumberTranslator(string userInput)
    {
      UserInput = userInput;
    }
    public List<int> GetNumberList()
    {
      return numberList;
    }

    public void SplitInput()
    {
      //string[] splitUserInput = UserInput.Split();
      int zeroCounter = UserInput.Length - 1;
      for(int i = 0; i < UserInput.Length; i++)
      {
        string tempStr = UserInput[i].ToString();
        for(int j = 0; j < zeroCounter; j++)
        {
          tempStr += "0";
        }
        zeroCounter--;
        numberList.Add(int.Parse(tempStr));
      }
    }
    public string GenerateWords()
    {
      string answerString = "";
      for(int i = 0; i < numberList.Count; i++)
      {
        switch(numberList.Count - i)
        {
          case 3:
            answerString += HundredsPlace[numberList[i]] + " ";
            break;
          case 2:
            if(numberList[i] == 10)
            {
              return answerString += Tens[numberList[i]+numberList[i+1]];
            }else{
              answerString += TensPlace[numberList[i]] + " ";
              break;
            }
          case 1:
            return answerString += OnesPlace[numberList[i]];
        }
      }
      return answerString;
    }
    public string GetUserInput()
    {
      return UserInput;
    }
  }
}
