using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthQuestion
{
    class Compression
    {
        static void Main(string[] args)
        {
            var newValue= " ";
            var str = "ddrrewwws";
            Wordcompressor wp = new Wordcompressor();
            newValue = wp.GetCompress(str);
            Console.ReadLine();
        }
    }
}
