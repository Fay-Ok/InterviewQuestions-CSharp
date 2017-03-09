using System;

namespace SecondQuestion {
    class ReverseAString {
        static void Main (string[] args) {
            GetReverseString ("Farzaneh is so cool!\0");
            getStringWithoutLib ("Farzaneh is so cool!\0");
        }

        private static void GetReverseString (string str) {
            char[] myString = str.ToCharArray ();
            Array.Reverse (myString);
            Console.WriteLine (myString);
        }

        private static void getStringWithoutLib (string str) {
            char[] strArray = new char[str.Length];

            var stringLength = str.Length - 1;
            for (int i = str.Length - 1; i >= 0; i--) {
                strArray[stringLength - i] = str[i];
            }
            Console.WriteLine (strArray);
        }
    }
}