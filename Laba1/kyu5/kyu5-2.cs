using System;
using System.Collections.Generic;

public class CaesarCipher
{
    //Метод шифрует строку s с использованием шифра Цезаря.  
    public static List<string> movingShift(string s, int shift)
    {
        char[] result = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            result[i] = ShiftChar(s[i], shift + i);
        }
        string encoded = new string(result);

        int partLength = (encoded.Length + 4) / 5;
        List<string> parts = new List<string>();
        for (int i = 0; i < 5; i++)
        {
            int start = i * partLength;
            int length = Math.Min(partLength, encoded.Length - start);
            parts.Add(encoded.Substring(start, length));
        }
        return parts;
    }
    public static string demovingShift(List<string> s, int shift)
    {
        
        string combined = string.Join("", s);

        char[] result = new char[combined.Length];
        for (int i = 0; i < combined.Length; i++)
        {
            result[i] = ShiftChar(combined[i], -shift - i);
        }
        return new string(result);
    }
    private static char ShiftChar(char c, int shift)
    {
        if (char.IsLetter(c))
        {
            char offset = char.IsUpper(c) ? 'A' : 'a';
            return (char)(((c - offset + shift) % 26 + 26) % 26 + offset);
        }
        return c;
    }
}
