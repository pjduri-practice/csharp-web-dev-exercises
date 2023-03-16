using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public ConeComparer() { }
        public int Compare(Cone x, Cone y)
        {
            if (x.Cost - y.Cost < 0)
            {
                return -1;
            }
            else if(x.Cost - y.Cost > 0)
            {
                return 1;
            }
            return 0;
        }
    }
}
