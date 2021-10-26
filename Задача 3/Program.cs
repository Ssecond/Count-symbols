using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = string.Empty;
            s = Console.ReadLine();
            char c = '(';
            int z = 0;
            for (int x = 0;x < s.Length;x++)
            {
                if (s[x] == c)
                {
                    z++;
                }
            }
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
