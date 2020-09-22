using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;

namespace PalindromeParser.Tests
{
  [TestClass]
  public class PalindromParserTests
  {
    [TestMethod]
    public void CheckPalin_IsPalindrome_True()
    {
      Palindrome testPalin = new Palindrome("tenet");
      Assert.AreEqual(true, testPalin.CheckPalin());
    }

    [TestMethod]
    public void CheckPalin_IsPalindrome_False()
    {
      Palindrome testPalin = new Palindrome("tenor");
      Assert.AreEqual(false, testPalin.CheckPalin());
    }
  }
}