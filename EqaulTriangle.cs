using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dr4
{
    class EqaulTriangle : Triangle
    {
        private double _square;

        public double Square()
        {
            var sqrt3 = Math.Sqrt(3);

            _square = _side1 * sqrt3 / 2;

            return _square;
        }
    }
}
