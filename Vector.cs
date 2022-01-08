using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestoner
{
    internal class Vector : IVector
    {
        SortedSet<Point> _Points = new SortedSet<Point>(new PointComparator());

        public void AddPoint(string name, int order)
        {
            if (order == _Points.Count + 1)
            {
                _Points.Add(new Point(this, name, order));
            }
            else
            {
                throw new ArgumentOutOfRangeException("ERROR! Trying to add a point with an invalid order");
            }
        }

        public void ChangePoint(string name, int order)
        {
            if (order > _Points.Count & order < 0)
            {
                throw new ArgumentOutOfRangeException("ERROR! Trying to assign an invalid point order. < 0 or > count");
            }
            Point p1 = null;
            Point p2 = null;
            foreach (Point p in _Points)
            {
                if(p.GetOrder() == order)
                {
                    p1 = p;
                    _Points.Remove(p1);
                }
                if (p.GetName().Equals(name))
                {
                    p2 = p;
                    _Points.Remove(p);
                }
            }
            _Points.Add(new Point(this, name, order));
            _Points.Add(new Point(this, p1.GetName(), p2.GetOrder()));
        }

        public void RemovePoint(string name)
        {
            foreach(Point p in _Points)
            {
                if (p.GetName().Equals(name))
                {
                    _Points.Remove(p);
                }
            }
        }

        public int Count()
        {
            return _Points.Count;
        }
    }
}
