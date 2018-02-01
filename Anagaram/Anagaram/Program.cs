using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagaram
{
    class Program
    {

        static void Main(string[] args)
        {
            var str1 = "abc";
            var str2 = "abb";
            int counter = 0;
            int f = 0;
            int[] letterFreq = new int[26];


            if(str1 == str2)
            {
                Console.WriteLine("Two strings are anagram!!");
            }

            if (!str1.Equals(str2) && str1.Length == str2.Length)
            {
                int i = 0;

                foreach (var c in str1)
                {

                    letterFreq[c - 'a']++;
                    i = 0;
                  
                }
                foreach (var c in str2)
                {
                    letterFreq[c - 'a']--;
                }

                foreach (var item in letterFreq)
                {
                    counter += Math.Abs(item);

                }
           
            }

           Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}