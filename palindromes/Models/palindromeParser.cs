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
      char[] reversePalinArray = PalinString.ToCharArray();
      Array.Reverse(reversePalinArray);
      string reversePalinStr = String.Join("",reversePalinArray);
      if (PalinString == reversePalinStr)
      {
        return true;
      } else {
        return false;
      }
    }
  }  
}