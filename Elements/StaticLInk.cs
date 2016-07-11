using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Youtube_MP3.Elements
{
    public static class StaticLink
    {
        public static string GetLink(string input)
        {
            int x = input.IndexOf("Link: ", 0) + "Link: ".Length;
            return input.Substring(x, input.Length - x);
        
        }
    }
}
