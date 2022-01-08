using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestoner
{
    public class ReversedPointComparator : IComparer<Point>
    {
        public int Compare(Point p1, Point p2)
        {
            return -(p2.GetOrder() - p1.GetOrder());
        }
    }
}
