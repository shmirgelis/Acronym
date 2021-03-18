using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        char[] delimitterChars = { ' ', ',', '.', '-', '_' };
        string[] words = phrase.Split(delimitterChars);

        return words.Where(word => !String.IsNullOrEmpty(word))
                                          .Select(word => word[0].ToString().ToUpper())
                                          .Aggregate((abbr, currentLetter) => abbr += currentLetter);
    }
}