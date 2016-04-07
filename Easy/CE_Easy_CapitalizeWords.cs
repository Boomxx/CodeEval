using System.IO;

class CE_Easy_CapitalizeWords
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                PrintStringWithInitialCaps(line);
            }
    }

    private static void PrintStringWithInitialCaps(string line)
    {
        string[] words = line.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (IsLower(words[i][0]))
                words[i] = string.Format("{0}{1}", (char)(words[i][0] - 32), words[i].Substring(1));
        }

        System.Console.WriteLine(string.Join(" ", words));
    }

    private static bool IsLower(char c)
    {
        return c >= 97 && c <= 122;
    }
}
