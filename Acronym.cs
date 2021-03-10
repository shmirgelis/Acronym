using System;


public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        char[] delimitterChars = { ' ', ',', '.', '-', '_' };
        string[] words = phrase.Split(delimitterChars);
        string acronym = "";
        foreach (string word in words)
        {
            if (word == "")   // cia turbut galima sutrumpint if statementa, bet nebepamenu kaip :)
            {
            }
            else
            {
                acronym += word[0].ToString().ToUpper();
            }
        }
        return acronym;
    }
}