using System;

namespace Question8 {
    class Program {
        static void Main (string[] args) {
            var substring = new Substring ();
            var string1 = "waterbottle";
            var string2 = "erbottlewat";

            var result2 = substring.IsWordRotated (string1, string2);
            Console.WriteLine (result2);
            Console.ReadLine ();

        }

    }
}