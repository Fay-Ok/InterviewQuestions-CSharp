using System;
using System.Linq;

namespace ThirdQuestion {
    class StringPermutation {
        static void Main (string[] args) {
            var firstString = "wertyuiopq".ToUpper ();
            var secondString = "pdoiuytrewq".ToUpper ();
            FindPermutation (firstString, secondString);
        }

        private static void FindPermutation (string firstString, string secondString) {
            if (firstString.Length != secondString.Length) {
                System.Console.WriteLine ("The Two Strings Are Not Permuted");
                return;
            }

            char[] firstStringArray = firstString.ToCharArray ();
            char[] secondStringArray = secondString.ToCharArray ();

            Array.Sort (firstStringArray);
            Array.Sort (secondStringArray);

            if (firstStringArray.SequenceEqual (secondStringArray)) {
                System.Console.WriteLine("The Two Strings Are Permuted");
            }
        }
    }
}