using System;

namespace ForthQuestion {
    class SpaceReplacer {
        static void Main (string[] args) {
            var str = "Mr John Smith    ";
            var strLength = 13;
            doReplaceWithBuiltInFunc (str);
            doReplaceWithoutBuiltInFunc (str, strLength);
        }

        private static void doReplaceWithoutBuiltInFunc (string str, int strLength) {
            string[] newString = new string[strLength];
            const string replacedChar = "%20";

            for (int i = 0; i < strLength; i++) {
                int asciCode = str[i];
                newString[i] = str[i].ToString ();

                if (asciCode == 32) {
                    newString[i] = replacedChar;
                    Console.WriteLine (asciCode);
                }

            }
            Console.WriteLine (string.Join ("", newString));

        }

        private static void doReplaceWithBuiltInFunc (string str) {
            var replacedSpaces = str.Trim ().Replace (" ", "%20");
            Console.WriteLine (replacedSpaces);
        }
    }
}