using System;
using static System.Convert;
using static System.Console;
using System.Collections;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add('L');
            list.Add(276);
            list.Add('I');
            list.Add(43);
            list.Add('S');
            list.Add(-20);
            list.Add(-3);
            list.Add(8);
            list.Add('T');
            list.Add(476);
            list.Add('O');
            list.Add(5);
            list.Add(7);
            list.Add('K');

            ArrayList list2 = new ArrayList();
            WriteLine("Chisla: ");
            for (int i = 0; i < list.Count; i++)
            {
                int n = 0;
                string a = list[i] + "";
                bool r = int.TryParse(a, out n); ;

                if (r == false)
                {
                    if (a == a.ToUpper())
                    {
                        list2.Add(list[i]);
                        list.RemoveAt(i);
                    }
                    else list.RemoveAt(i);
                }
            }
            foreach (object o in list)
            {
                WriteLine(o);
            }
            WriteLine("Bykvi: ");
            foreach (object o in list2)
            {
                WriteLine(o);
            }
            ReadLine();
        }
    }
}
