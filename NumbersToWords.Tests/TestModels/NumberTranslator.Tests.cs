using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;
using System;
using System.Collections.Generic;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumberTranslatorTest
  {
    [TestMethod]
    public void Constructor_Test()
    {
      string userInputTest = "4";
      NumberTranslator testNumberTranslator = new NumberTranslator(userInputTest);
      Assert.AreEqual("4", testNumberTranslator.GetUserInput());
    }
    [TestMethod]
    public void SplitInput_Test()
    {
      string userInputTest = "44";
      NumberTranslator testNumberTranslator = new NumberTranslator(userInputTest);
      testNumberTranslator.SplitInput();
      Assert.AreEqual(40, testNumberTranslator.GetNumberList()[0]);
      Assert.AreEqual(4, testNumberTranslator.GetNumberList()[1]);
    }
    [TestMethod]
    public void GenerateWords_Test()
    {
      string userInputTest = "444";
      NumberTranslator testNumberTranslator = new NumberTranslator(userInputTest);
      testNumberTranslator.SplitInput();
      Assert.AreEqual("four hundred forty four", testNumberTranslator.GenerateWords());
    }
    [TestMethod]
    public void GenerateWords_TestTensException()
    {
      string userInputTest = "19";
      NumberTranslator testNumberTranslator = new NumberTranslator(userInputTest);
      testNumberTranslator.SplitInput();
      Assert.AreEqual("nineteen", testNumberTranslator.GenerateWords());
    }
  }
}
