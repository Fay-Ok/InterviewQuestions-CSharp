using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstInterviewQuestion {
    class AllUniqueCharacters {
        static void Main (string[] args) {
            var str = "^&)~12de456!#qwertyuiopasdfghakaiqjkhjkhfjshljfhsliuhflnsihnfiusybfiluybweiuyfosiudyfg isuygoiuysliugwurgluiesliuvlsiulivgrwwwwwwwwwasscsccxasvccvzlmnbvcxz12344";
            WithoutDataStructure (str);
            UsingDictionary (str);
            UsingHashSet (str);
            UsingArray (str);
        }

        private static void UsingDictionary (string str) {
            if (str.Length != 128) {
                System.Console.WriteLine ("The string is not containing all the unique characters");
            }
            Dictionary<int, char> charDictionary = new Dictionary<int, char> ();
            for (int i = 0; i < str.Length; i++) {
                int charDit = str[i];
                if (charDictionary.ContainsKey (str[i])) {
                    System.Console.WriteLine ("duplication  " + charDictionary[str[i]]);
                } else {
                    charDictionary.Add (charDit, str[i]);
                }
            }
        }

        private static void WithoutDataStructure (string str) {
            if (str.Length != 128) {
                System.Console.WriteLine ("The string is not containing all the unique characters");
            } else {
                var orderString = String.Concat (str.OrderBy (s => s));
                for (int i = 0; i < orderString.Length; i++) {
                    if (orderString[i] == orderString[i + 1]) {
                        System.Console.WriteLine ("There are dulpicates in the string");
                        break;
                    }
                }
            }
        }
        private static void UsingHashSet (String strValue) {
            if (strValue.Length != 128) {
                System.Console.WriteLine ("The string is not containing all the unique characters");
            }
            HashSet<int> hs = new HashSet<int> ();
            for (int i = 0; i < strValue.Length; i++) {
                if (hs.Contains (strValue[i])) {
                    System.Console.WriteLine ("Dulplicate --> " + strValue[i]);
                }
                hs.Add (strValue[i]);
            }
        }

        private static void UsingArray (string str) {
            if (str.Length != 128) {
                System.Console.WriteLine ("The string does not contain all the unique characters");

            } else {

                int[] AscIIArr = new int[128];
                for (int i = 0; i < str.Length; i++) {
                    int asciiCode = str[i];
                    if (AscIIArr.Contains (asciiCode)) {
                        continue;
                    } else {
                        AscIIArr[asciiCode] = asciiCode;
                    }
                }

            }
        }

    }
}