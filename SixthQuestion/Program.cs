using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthQuestions
{
    class MatrixImage
    {
        static void Main(string[] args)
        {
            var imageSize = 3;
            ImageRotator mr = new ImageRotator();
            mr.GetRotate(imageSize);
            Console.ReadLine();

        }
    }
}
