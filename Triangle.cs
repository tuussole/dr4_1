using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dr4
{
    public class Triangle
    {
        protected int _side1, _side2, _side3;

        public int Side1 { get => _side1; set => _side1 = value; }
        public int Side2 { get => _side2; set => _side2 = value; }
        public int Side3 { get => _side3; set => _side3 = value; }

        public int Perimetr()
        {
            return _side1 + _side2 + _side3;
        }

        public double Angle1and2()
        {
            return CalculateAngle(_side1, _side2, _side3);
        }

        public double Angle2and3()
        {
            return CalculateAngle(_side2, _side3, _side1);
        }

        public double Angle3and1()
        {
            return CalculateAngle(_side3, _side1, _side2);
        }

        private double CalculateAngle(int a, int b, int c)
        {
            var upper = b * b + a * a - c * c;
            var downer = 2 * b * a;

            double cos = (double)upper / (double)downer;

            return (180 / Math.PI) * Math.Acos(cos);
        }
    }
}
