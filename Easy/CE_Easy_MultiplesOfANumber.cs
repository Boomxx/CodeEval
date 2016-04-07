using System;
using System.IO;

class CE_Easy_MultiplesOfANumber
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
                int n = Convert.ToInt16(parts[0]);
                int x = Convert.ToInt16(parts[1]);

                Console.WriteLine(NextMultiple(n, x).ToString());
            }
    }

    private static int NextMultiple(int n, int x)
    {
        //The power of 2 of n, for bit shifting
        int p = (int)Math.Log(x, 2);

        return (((n - 1) >> p) + 1) << p;
    }
}
