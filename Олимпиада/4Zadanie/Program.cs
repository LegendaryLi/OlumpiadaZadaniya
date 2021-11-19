using System;
using System.IO;
using System.Collections;

namespace OlumpZad4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rules = true;
            while (rules)
            {
                ArrayList dates = new ArrayList();
                StreamReader sr = new StreamReader("input.txt");
                string nomerofmeteoritstroka = sr.ReadLine();
                int k;
                try { k = int.Parse(nomerofmeteoritstroka.Split(" ")[1]); }
                catch { break; }
                if (k < 1 || k > Math.Pow(10, 5)) { break; };
                while (!sr.EndOfStream)
                {
                    dates.Add(sr.ReadLine());
                }
                dates.Remove(0);
                try
                {
                    for (int i = 0; i < dates.Count; i++)
                    {
                        int year = int.Parse(dates[i].ToString().Split(" ")[0].Split("-")[0]);
                        if (year < 1600 || year > 2500) break;
                        int month = int.Parse(dates[i].ToString().Split(" ")[0].Split("-")[1]);
                        if (month < 1 || month > 12) break;
                        int day = int.Parse(dates[i].ToString().Split(" ")[0].Split("-")[2]);
                        if (day < 1 || day > 31) break;
                        int hour = int.Parse(dates[i].ToString().Split(" ")[1].Split(":")[0]);
                        if (hour < 0 || hour > 23) break;
                        int minute = int.Parse(dates[i].ToString().Split(" ")[1].Split(":")[1]);
                        if (minute < 0 || minute > 59) break;
                        int second = int.Parse(dates[i].ToString().Split(" ")[1].Split(":")[2]);
                        if (second < 0 || second > 59) break;
                    }
                }
                catch { break; }
                int n = dates.Count;
                if (n != int.Parse(nomerofmeteoritstroka.Split(" ")[0])) break;
                dates.Sort();
                foreach (object e in dates)
                {
                    Console.WriteLine(e);
                }
                string neededdate = dates[k - 1].ToString();
                Console.WriteLine();
                Console.WriteLine(neededdate);
                sr.Close();
                StreamWriter sw = new StreamWriter("output.txt");
                sw.WriteLine(dates[k - 1].ToString());
                sw.Close();
                rules = false;
                break;
            }
            if (rules) Console.WriteLine("Ошибка в данных");
        }
    }
}
