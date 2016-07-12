using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_MP3.Attributes
{
    public class Percentage
    {
        private static int internalPercent = 0;
        public static int GetPercent {

            get
            {
                return internalPercent;
            }

            set
            {
                internalPercent = value;
            } 
        }
    }
}
