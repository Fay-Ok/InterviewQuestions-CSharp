using System;
using System.Collections.Generic;
using System.Linq;

namespace FifthQuestion
{
    internal class Wordcompressor
    {
        private Dictionary<char, int> charDic = new Dictionary<char, int>();
        private string newStringWithValues;

        internal string GetCompress(string str)
        {
            CreateDictionary(str);
            newStringWithValues = PrintDictionary();
            if (newStringWithValues.Length > str.Length)
            {
                return str;
            }
            return newStringWithValues;
        }


        private string PrintDictionary()
        {
            var newString = "";
            foreach (var kvp in charDic)
            {
                newString += kvp.Key;
                newString += kvp.Value;
            }
            Console.WriteLine(string.Join("", charDic.Select(kv => kv.Key + "" + kv.Value)));
            return newString;
        }

        private void CreateDictionary(string str)
        {
            for (var i = 0; i < str.Length; i++)
            {
                if (!charDic.ContainsKey(str[i]))
                {
                    charDic.Add(str[i], 1);
                }
                else
                {
                    charDic[str[i]] += 1;
                }

            }
        }
    }
}