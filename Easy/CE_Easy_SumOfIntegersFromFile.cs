using System;
using System.IO;

class CE_Easy_SumOfIntegersFromFile
{
    static void Main(string[] args)
    {
        int sum = 0;

        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                sum += Convert.ToInt16(line);
            }

        Console.Write(sum);
    }
}
