using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        char[] delimitterChars = { ' ', ',', '.', '-', '_' };
        string[] words = phrase.Split(delimitterChars);

        var firstLetters = words.Where(w => !String.IsNullOrEmpty(w))
                                .Select(w => w.ElementAt(0).ToString())
                                .Aggregate((w1, w2) => $"{w1.ToUpper()}{w2.ToUpper()}");

        return firstLetters;
    }
}