using System;
using System.IO;

class CE_Easy_FibonacciSeries
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                Console.WriteLine(Fibonacci(Convert.ToInt16(line)));
            }
    }

    private static int Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        int last = 1;
        int result = 1;

        for (int i = 0; i < (n - 2); i++)
        {
            result += last;
            last = result - last;
        }

        return result;
    }
}