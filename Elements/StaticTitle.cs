
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_MP3.Elements
{
    public static class StaticTitle
    {
        public static string GetTitle(string input)
        {
            int x = input.IndexOf("Title: ", 0) + 7;
            int end = input.IndexOf("Length: ", x);
            return input.Substring(x, end - x);
        }
    }
}
