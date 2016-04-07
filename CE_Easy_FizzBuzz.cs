using System;
using System.IO;
using System.Text;
using System.Linq;

class CE_Easy_FizzBuzz
{
    static void Main(string[] args)
    {
        var builder = new StringBuilder();

        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                var parts = line.Split(' ');
                var fDiv = Convert.ToInt16(parts[0]);
                var bDiv = Convert.ToInt16(parts[1]);
                var countTo = Convert.ToInt16(parts[2]);
                var range = Enumerable.Range(1, countTo).Select(n => n.ToString()).ToList();

                for (int i = 0; i < countTo; i++)
                {
                    var c = Convert.ToInt16(range[i]);
                    builder.Clear();

                    if (c % fDiv == 0)
                        builder.Append("F");
                    if (c % bDiv == 0)
                        builder.Append("B");

                    if (builder.Length > 0)
                        range[i] = builder.ToString();
                }

                Console.WriteLine(string.Join(" ", range));
            }
    }
}