using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GewaechshausMitAnimation;

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
        public static int ShowActualSliderIndoorValue(int temp, double y)
        {
            for (int i = temp; i < y || i > y;)
            {
                if (y >= i)
                {
                    i++;
                }
                else if (y <= i)
                {
                    i--;
                }
                else
                {
                    return i;
                }

                
                Thread.Sleep(200);

                return i;

            }

            return 0;
        }

    }
}
