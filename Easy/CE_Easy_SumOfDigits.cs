using System;
using System.IO;

class CE_Easy_SumOfDigits
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                Console.WriteLine(SumOfDigits(line));
            }
    }

    private static int SumOfDigits(string line)
    {
        int sum = 0;

        foreach (char d in line)
        {
            sum += d - '0';
        }

        return sum;
    }
}
