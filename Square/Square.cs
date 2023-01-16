namespace Square
{
    public interface ISquare {

        double Calculate();
   

    }

    public abstract class ShapeFactory : ISquare
    {
        public abstract double Calculate();
    }

    public class TriangleFactory : ShapeFactory
    {
        private int _a;
        private int _b;
        private int _c;
        public TriangleFactory(int a, int b, int c) { _a = a;_b = b; _c = c; }
        public override double Calculate()
        {
            double P = (_a + _b + _c) / 2;
            return Math.Sqrt(P * (P - _a) * (P - _b) * (P - _c));

        }
        public bool IsRectangular()
        {
            return Math.Pow(_a, 2) == (Math.Pow(_b, 2) + Math.Pow(_c, 2))? true: Math.Pow(_b, 2) == (Math.Pow(_a, 2) + Math.Pow(_c, 2))? true: Math.Pow(_c, 2) == (Math.Pow(_a, 2) + Math.Pow(_b, 2))? true:false;
        }
    }
    public class CircleFactory : ShapeFactory
    {
        private int _radius;
        public CircleFactory(int radius) { _radius = radius; }
        public override double Calculate()
        {
            return Math.PI*Math.Pow(_radius, 2);
        }
    }

    public class Shape
    {
        private ShapeFactory _factory;
        public Shape(ShapeFactory factory)
        {
            _factory = factory;
        }
        public double Calculate()
        {
            return _factory.Calculate();
        }
        public ShapeFactory GetShape()
        {
            return _factory;
        }

    }
}