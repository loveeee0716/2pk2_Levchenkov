using System;
using System.Runtime.InteropServices;

class HelloWorld {
    static void Main()
    {
        string text = Console.ReadLine() + " ";
        int len = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ' ')
            {
                len += 1;
            }
        }
        string[] words = new string[len];
        string word = "";
        int counter = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsWhiteSpace(Convert.ToChar(text[i])) == false)
            {
                word += text[i];
            }
            else
            {
                words[counter] = word;
                word = "";
                counter += 1;
            }
        }

        int llen = text.Length;
        string lword = "";
        foreach (string str in words)
        {
            if (str.Length < llen)
            {
                llen = str.Length;
                lword = str;
            }
        }

        string new_word = lword;
        foreach (string wword in words)
        {
            if (wword != lword)
            {
                new_word += " " + wword;
            }
        }
        Console.WriteLine(new_word);
    }
}