using System;
using System.IO;

namespace OlumpZad2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = File.ReadAllLines("input.txt");
            int MaxStrings = int.Parse(data[0].Split(" ")[0]);
            int Paragraph = int.Parse(data[0].Split(" ")[1]);
            int Pages = 0;
            int FreeLines = MaxStrings;
            foreach (string n in data[1].Split(" "))
            {
                if (FreeLines - int.Parse(n) < 0)
                {
                    FreeLines = MaxStrings - int.Parse(n);
                    ++Pages;
                }
                else if (FreeLines - int.Parse(n) == 0)
                {
                    FreeLines = MaxStrings;
                    ++Pages;
                }
                else
                {
                    FreeLines -= int.Parse(n);
                }
            }
            if (FreeLines < 10) ++Pages;
            File.WriteAllText("output.txt", Pages.ToString());
        }
    }
}
