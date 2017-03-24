namespace Question8 {
    internal class Substring {
        public Substring () {

        }
        internal bool IsWordRotated (string string1, string string2) {
            var stringJoin = string2 + string2;
            return IsSubString (stringJoin, string1);
        }

        internal bool IsSubString (string string1, string string2) {
            return string1.Contains (string2);
        }

    }
}