using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coursach.Extension
{
    public static class intExtension
    {
        public static string  ZeroDigitToEmty(this double number)
        {
            if (number == 0) return "";

            return number.ToString();

        }


    }
}
