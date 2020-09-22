using System;

namespace Palindromes
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter word: ");
      string userWord = Console.ReadLine();

      Palindrome palin = new Palindrome(userWord);

      if (palin.CheckPalin())
      {
        Console.WriteLine("------------------------");
        Console.WriteLine("-                      -");
        Console.WriteLine("-  It's a Palindrome!  -");
        Console.WriteLine("-                      -");
        Console.WriteLine("------------------------");
      } else 
      {
        Console.WriteLine("------------------------");
        Console.WriteLine("-                      -");
        Console.WriteLine("-  Not a Palindrome!!  -");
        Console.WriteLine("-                      -");
        Console.WriteLine("------------------------");
      }
    }
  }
}