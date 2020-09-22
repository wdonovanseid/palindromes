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
      // put that thang down, flip it, and reverse it
      // Array.Reverse(reversePalinArray);
      char[] newReversePalinArray = new char[reversePalinArray.Length];
      for (int i=0; i<reversePalinArray.Length; i++)
      {
        Console.WriteLine("pushing the char: "+reversePalinArray[reversePalinArray.Length-i-1]);
        newReversePalinArray[i] = reversePalinArray[reversePalinArray.Length-i-1];
      }
      // string reversePalinStr = String.Join("",reversePalinArray); from old
      string reversePalinStr = String.Join("",newReversePalinArray);
      if (PalinString == reversePalinStr)
      {
        return true;
      } else {
        return false;
      }
    }
  }  
}