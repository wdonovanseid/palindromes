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
      // string[] palinArray = PalinString.Split("");
      string[] reversePalinArray = PalinString.Split("");
      Array.Reverse(reversePalinArray);
      string reversePalinStr = String.Join("",reversePalinArray);
      // Console.WriteLine(palinArray[0]);
      if (PalinString == reversePalinStr)
      {
        return true;
      } else {
        return false;
      }
    }
  }  
}