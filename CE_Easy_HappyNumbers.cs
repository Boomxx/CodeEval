using System;
using System.IO;

class CE_Easy_HappyNumbers
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                Console.WriteLine(IsHappy(line));
            }
    }

    private static int IsHappy(string n)
    {
        var unhappyseq = new int[] { 4, 16, 37, 58, 89, 145, 42, 20 };
        int result = SumOfDigitsSquared(n);

        while (result != 1)
        {
            if (Array.IndexOf(unhappyseq, result) != -1)
                return 0;
            else
                result = SumOfDigitsSquared(result.ToString());
        }

        return 1;
    }

    private static int SumOfDigitsSquared(string n)
    {
        int sum = 0;

        foreach (char d in n)
        {
            sum += (d - '0') * (d - '0');
        }

        return sum;
    }
}