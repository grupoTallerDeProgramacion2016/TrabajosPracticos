using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string word1, word2;
                Console.Write("Entre una palabra: ");
                word1 = Console.ReadLine();

                Console.Write("Entre otra palabra: ");
                word2 = Console.ReadLine();
                if (SonAnagramas(word1, word2) == false)
                    Console.Write("No son anagramas.");
                else
                    Console.Write("Son anagramas.");
                Console.WriteLine();
                Console.WriteLine();

            }
        }

        public static bool SonAnagramas(string a, string b)
        {
            int count1, count2;
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    count1 = 0;
                    count2 = 0;
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (a[i] == b[j])
                            count1++;
                        if (a[i] == a[j])
                            count2++;
                    }
                    if (count1 != count2)
                        return false;
                }
                return true;
            }
            else
                return false;
        }
    }
}