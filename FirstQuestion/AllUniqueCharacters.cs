using System;
using System.Collections.Generic;

namespace FirstInterviewQuestion {
    class AllUniqueCharacters {
        static void Main (string[] args) {
            var strValue = "qwertyuiopasdfghakaiqjklmnbvcxz12344";
            IsUniqueChar (strValue);
        }

        private static void IsUniqueChar (String strValue) {
            HashSet<int> hs = new HashSet<int> ();
            for (int i = 0; i < strValue.Length; i++) {
                if (hs.Contains (strValue[i])) {
                    System.Console.WriteLine ("Dulplicate --> " + strValue[i]);
                }
                hs.Add (strValue[i]);
            }
        }
    }
}