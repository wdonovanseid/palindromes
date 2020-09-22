using System;

namespace Palindromes
{
  public class Palindrome
  {
    public string PalinString { get; set; }
    public Palindrome( string palinString )
    {
      PalinString = palinString;
    }

    public bool CheckPalin()
    {
      string[] palinArray = PalinString.Split("");
      string[] reversePalinArray = palinArray;
      Array.Reverse(palinArray);
      if (palinArray == reversePalinArray)
      {
        return true;
      } else {
        return false;
      }
    }
  }  
}