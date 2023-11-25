using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GewaechshausMitAnimation;
using GewaechshausMitAnimation.Model;

namespace GewaechshausMitAnimation.Controller
{
    public static class Functions
    {
        public static string ExtWriteLine(this string x)
        {
            Console.WriteLine(x);
            return x;
        }
        public static string ExtWrite(this string x)
        {
            Console.Write(x);
            return x;
        }
    }
}

