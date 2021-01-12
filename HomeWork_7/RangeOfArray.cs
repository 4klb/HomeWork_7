using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_7
{
    public class RangeOfArray
    {
        public int LowerIndex { set; get; }
        public int UpperIndex { set; get; }

        public RangeOfArray() { } 

        public RangeOfArray(int lowerIndex, int upperIndex)
        {
            this.LowerIndex = lowerIndex;
            this.UpperIndex = upperIndex;
        }
    }
}
