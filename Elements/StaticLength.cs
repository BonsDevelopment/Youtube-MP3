using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_MP3.Elements
{
    public static class StaticLength
    {
        public static string GetLength(string input)
        {
        
            int x = input.IndexOf("Length: ", 0) + "Length: ".Length;
            int end = input.IndexOf("Link: ", x);
            return input.Substring(x, input.Length - end);
        
        }
    }
}
