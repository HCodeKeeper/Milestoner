using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestoner
{
    internal interface IVector
    {
        void AddPoint(string name, int order);

        void RemovePoint(string name);

        void ChangePoint(string name, int order);

        int Count();
    }
}
