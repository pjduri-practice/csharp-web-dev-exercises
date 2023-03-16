﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            double costDiff = x.Cost - y.Cost;
            if (costDiff > 0)
            {
                return 1;
            }
            else if (costDiff < 0)
            {
                return -1;
            }
            return 0;
        }
    }
}
