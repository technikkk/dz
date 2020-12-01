using System;
using System.Text.RegularExpressions;

namespace dz
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "";
            string s2;
            bool res = false;
            s1 = Console.ReadLine();
            s2 = s1;
            s1 = s1.ToLower();
            s1 = Regex.Replace(s1, "(?i)[^А-ЯЁA-Z]", "");
            for (int i = 0, j = s1.Length - 1; i < j; i++, j--)
            {
                if (s1[i] == s1[j])
                {
                    res = true;
                }
                else
                {
                    res = false;
                    break;
                }
            }
            if (res == true)
            {
                Console.WriteLine($"{s2} is palindrom");
            }
            else
            {
                Console.WriteLine($"{s2} is not palindrom");
            }

        }
    }
}
