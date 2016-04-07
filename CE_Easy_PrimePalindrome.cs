using System;

class CE_Easy_PrimePalindrome
{
    static void Main(string[] args)
    {
        const int max = 1000;

        bool[] arr = MakeSieve(max);

        for (int i = max; i != 0; i--)
        {
            if (arr[i])
            {
                if (IsPalindrome(i.ToString()))
                {
                    Console.WriteLine(i.ToString());
                    break;
                }
            }
        }
    }

    private static bool[] MakeSieve(int max)
    {
        bool[] sieve = new bool[max + 1];
        var root = Math.Sqrt(max);

        for (int i = 2; i <= max; i++) sieve[i] = true;

        for (int i = 2; i <= root; i++)
        {
            if (sieve[i])
            {
                for (int j = i * i; j <= max; j += i)
                    sieve[j] = false;
            }
        }

        return sieve;
    }

    private static bool IsPalindrome(string item)
    {
        char[] chrs = item.ToCharArray();

        for (int i = 0, j = chrs.Length - 1; i < j; i++, j--)
        {
            if (chrs[i] != chrs[j])
            {
                return false;
            }
        }

        return true;
    }
}