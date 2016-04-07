using System;

class CE_Easy_MultiplicationTables
{
    static void Main(string[] args)
    {
        PrintMultiplicationTables(12);
    }

    private static void PrintMultiplicationTables(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (j == 1)
                    Console.Write(string.Format("{0,4}", i * j).TrimStart());
                else
                    Console.Write(string.Format("{0,4}", i * j));
            }

            Console.WriteLine();
        }
    }
}
