using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        char[] delimitterChars = { ' ', ',', '.', '-', '_' };
        string[] words = phrase.Split(delimitterChars);
        string acronym = "";
        
        var firstLetters = words.Where(w => !String.IsNullOrEmpty(w))
                                .Select(w => w.ElementAt(0));

        foreach (char letter in firstLetters)
        {
            acronym += Char.ToUpper(letter);
        }
        return acronym;
    }
}