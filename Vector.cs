using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Milestoner
{
    public class Vector : IVector
    {
        IGui _Gui;
        SortedSet<Point> _Points = new SortedSet<Point>(new PointComparator());

        public Vector(IGui gui)
        {
            _Gui = gui;
        }

        public void AddPoint(string name, int order)
        {
            if (order == _Points.Count + 1)
            {
                _Points.Add(new Point(this, name, order));
            }
            Notify(_Points);
        }

        private void RewritePoints(SortedSet<Point> points)
        {
            _Points = points;
        }

        public void ChangePoint(string name, int order)
        {
            if (order > _Points.Count & order < 0)
            {
                throw new ArgumentOutOfRangeException("ERROR! Trying to assign an invalid point order. < 0 or > count");
            }
            Point p1 = null;
            Point p2 = null;
            SortedSet<Point> points = new SortedSet<Point>(_Points, new PointComparator());
            foreach (Point p in _Points) //
            {
                if (p.GetOrder() == order & p.GetName().Equals(name))
                {
                    break;
                }
                else
                {
                    if (p.GetOrder() == order)
                    {
                        p1 = p;
                        points.Remove(p);
                    }
                    else if (p.GetName().Equals(name))
                    {
                        p2 = p;
                        points.Remove(p);
                    }
                }
                
            }
            if(p1 != null & p2 != null)
            {
                points.Add(new Point(this, name, order));
                points.Add(new Point(this, p1.GetName(), p2.GetOrder()));
                RewritePoints(points);
            }

            Notify(_Points);
        }

        public void Notify(SortedSet<Point> points)
        {
            this._Gui.DataUpdate(points);
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
            Notify(_Points);
        }

        public int Count()
        {
            return _Points.Count;
        }

        public SortedSet<Point> GetPoint()
        {
            return new SortedSet<Point>(_Points, _Points.Comparer);
        }
    }
}
