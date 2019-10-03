using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Score_Calculator
{
    /// <summary>
    /// Strike class to store extra strike points.
    /// </summary>
    class Strike
    {
        public int point1;
        public int point2;
        public Strike()
        {
            //Initilaized as negative number as 0 to 10 are possible values.
            point1 = -1;
            point2 = -1;
        }
    }
}
