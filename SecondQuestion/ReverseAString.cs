using System;

namespace SecondQuestion {
    class ReverseAString {
        static void Main (string[] args) {
            const string reversableString = "Today was sunny!\0";
            GetReverseString(reversableString);
            getStringWithoutLib(reversableString);
        }

        private static void GetReverseString (string str) {
            char[] myString = str.ToCharArray ();
            Array.Reverse (myString);
            Console.WriteLine (myString);
        }

        private static void getStringWithoutLib (string str) {
            char[] strArray = new char[str.Length];

            var stringLength = str.Length - 1;
            for (int i = stringLength; i >= 0; i--) {
                strArray[stringLength - i] = str[i];
            }
            Console.WriteLine (strArray);
        }
    }
}