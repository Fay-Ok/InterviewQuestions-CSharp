using System;

namespace SixthQuestions {
    internal class ImageRotator {
        internal void GetRotate (int imageSize) {
            int[, ] m = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            MatrixPrinter (imageSize, m);
            MatrixRotator (imageSize, m);
        }

        private void MatrixRotator (int imageSize, int[, ] m) {
            int[, ] f = new int[3, 3];
            int temp;
            var j = 0;
            for (var i = 0; i < Math.Ceiling (imageSize / 2.0); i++) {
                for (j = 0; j < Math.Ceiling (imageSize / 2.0); j++) {
                    temp = m[i, j];
                    m[i, j] = m[j, imageSize - i - 1];
                    m[j, imageSize - i - 1] = temp;

                }
                temp = m[i, j - 2];
                m[i, j - 2] = m[imageSize - 1, imageSize - i - 1];
                m[imageSize - 1, imageSize - i - 1] = temp;

            }
            MatrixPrinter (3, m);
        }

        private static void MatrixPrinter (int imageSize, int[, ] m) {

            for (var i = 0; i < imageSize; i++) {
                var row = "| ";
                var newRow = "---";

                for (var j = 0; j < imageSize; j++) {
                    row += m[i, j].ToString () + " | ";
                    newRow += "---";
                }
                Console.WriteLine (row);
                Console.WriteLine (newRow);

            }
            Console.WriteLine ("\n\n");
        }
    }
}