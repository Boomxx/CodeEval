using System.IO;

class CE_Easy_NModM
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
                System.Console.WriteLine(Mod(System.Convert.ToInt16(parts[0]), System.Convert.ToInt16(parts[1])));
            }
    }

    private static int Mod(int N, int M)
    {
        return N - (N / M) * M;
    }
}