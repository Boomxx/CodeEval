using System;
using System.IO;

class CE_Easy_RightmostChar
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                var parts = line.Split(',');
                Console.WriteLine(parts[0].LastIndexOf((char)parts[1][0]));
            }
    }
}