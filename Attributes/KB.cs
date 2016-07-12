using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_MP3.Attributes
{
    public class KB
    {
        private static int internalKB = 0;

        private static int internalKBTotal = 0;

        public static int GetKB
        {

            get
            {
                return internalKB;
            }

            set
            {
                internalKB = value;
            }
        }

        public static int GetKBTotal
        {

            get
            {
                return internalKBTotal;
            }

            set
            {
                internalKBTotal = value;
            }
        }
    }
}
