using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestoner
{
    internal class PointComparator : IComparer<Point>
    {
        public int Compare(Point p1, Point p2)
        {
            return p2.GetOrder() - p1.GetOrder();
        }
    }
}
