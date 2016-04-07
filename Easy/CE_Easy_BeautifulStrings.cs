using System.IO;
using System.Collections.Generic;
using System.Linq;

class CE_Easy_BeautifulStrings
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                System.Console.WriteLine(GetBeauty(line));
            }
    }

    private static int GetBeauty(string line)
    {
        var map = new Dictionary<char, int>();

        foreach (char c in line)
        {
            char newc = '\0';

            if (c >= 65 && c <= 90)
            {
                newc = (char)(c + 32);
            }
            else if (c >= 97 && c <= 122)
            {
                newc = c;
            }
            else
            {
                continue;
            }

            if (map.ContainsKey(newc))
                map[newc] += 1;
            else
                map[newc] = 1;
        }

        var sorted = map.OrderByDescending(e => e.Value);

        int sum = 0;
        int i = 0;

        foreach (var pair in sorted)
        {
            sum += (26 - i++) * pair.Value;
        }

        return sum;
    }
}
