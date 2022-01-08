using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestoner
{
    internal class Point
    {
        private Vector _Vector;
        private string _Name;
        private int _Order;
        public Point(Vector vector, string name, int order)
        {
            _Vector = vector;
            _Name = name;
            _Order = order;
        }

        public string GetName()
        {
            return _Name;
        }

        public int GetOrder()
        {
            return _Order;
        }
    }
}
