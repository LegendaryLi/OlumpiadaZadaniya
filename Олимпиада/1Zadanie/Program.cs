using System;
using System.IO;

namespace OlumpZad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(File.ReadAllText("input.txt"));
            int dayOfStudent = day + 3 < 7 ? day + 3 : day + 3 - 7;
            File.WriteAllText("output.txt", dayOfStudent.ToString());
        }
    }
}
