using System;
using System.IO;

class CE_Easy_Lowercase
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                var builder = new System.Text.StringBuilder();

                foreach (char c in line)
                {
                    if (c >= 65 && c <= 90)
                        builder.Append((char)(c + 32));
                    else
                        builder.Append(c);
                }

                Console.WriteLine(builder.ToString());
            }
    }
}