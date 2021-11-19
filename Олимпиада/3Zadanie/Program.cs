using System;
using System.IO;

namespace OlumpZad3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            if (!File.Exists("input.txt"))
            {
                File.Create("input.txt").Dispose();
            }
            string str = null;
            bool error = false;
            while (!sr.EndOfStream) { str += sr.ReadLine(); }
            sr.Close();
            if (str == null) { error = true; }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '1' && str[i] != '0') error = true;
            }
            if (error == false)
            {
                string temp = null;
                int n = 0;
                int count = 0;

                for (int i = 0; i < str.Length / 8; i++)
                {
                    temp = str.Substring(n, 8);
                    if (temp.Substring(0, 2) != "10")
                        count++;
                    n += 8;
                }
                StreamWriter sw = new StreamWriter("output.txt");
                if (!File.Exists("output.txt"))
                {
                    File.Create("output.txt").Dispose();
                }
                sw.WriteLine(count);
                sw.Close();
                Console.WriteLine("Программа завершила работу...");
            }
            else if (error == true)
            {
                Console.WriteLine("Строка содержит недопустимые символы");
            }
        }
    }
}
