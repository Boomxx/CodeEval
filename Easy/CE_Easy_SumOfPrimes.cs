using System;
using System.Linq;

class CE_Easy_SumOfPrimes
{
    static void Main(string[] args)
    {
        const int n = 1000;

        //Estimate the max for fitting n primes
        int max = (int)(n * Math.Log(n * Math.Log(n)));
        bool[] arr = MakeSieve(max);

        var sieve = arr.Select((x, i) => new {
            Number = i,
            isPrime = x
        });

        var primes = sieve.Where(x => x.isPrime).Select(x => x.Number).Take(n);

        Console.WriteLine(primes.Sum());
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
}
