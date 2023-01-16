using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square.Tests
{
    internal class RectangleFactory:ShapeFactory
    {
        private int _a;
        private int _b;
        public RectangleFactory(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public override double Calculate()
        {
            return _a * _b;
        }
    }
}
