using System;
using System.Text.RegularExpressions;

public class Wildcard : Regex
{
    public Wildcard(string pattern)  : base(WildcardToRegex(pattern))
    {
    }
    
    public Wildcard(string pattern, RegexOptions options)  : base(WildcardToRegex(pattern), options)
    {
    }
    
    public static string WildcardToRegex(string pattern)
    {
      return "^" + Regex.Escape(pattern).
      Replace("\\*", ".*").
      Replace("\\?", ".") + "$";
    }

    public static void Main(string[] args)
    {
      string sIn="";
       if (args == null)
        {
          Console.WriteLine("Input wildCard: ");
          sIn=Console.ReadLine();
        }else
         sIn=args[0];
       Console.WriteLine(Wildcard.WildcardToRegex( sIn) );
       Console.ReadLine();
    }
}
