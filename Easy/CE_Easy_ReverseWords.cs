using System;
using System.IO;

class CE_Easy_ReverseWords
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                Console.WriteLine(string.Join(" ", ReverseWords(line)));
            }
    }

    private static string[] ReverseWords(string line)
    {
        var words = line.Split(' ');
        Array.Reverse(words);

        return words;
    }
}
