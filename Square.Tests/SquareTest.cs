
using Xunit;

namespace Square.Tests
{
  
    public class SquareTest
    {
        [Fact]
        public void CalcCircleSquare()
        {
            var shape = new Shape(new CircleFactory(4));

            var result = shape.Calculate();

            Assert.Equal(50, Math.Round(result,0));
        }

        [Fact]
        public void CalcTriangleSquare()
        {
            var shape = new Shape(new TriangleFactory(5, 3, 4));

            var result = shape.Calculate();

            Assert.Equal(6, result);
        }
        [Fact]
        public void IsRectangular()
        {
            var shape = new Shape(new TriangleFactory(4, 3, 5));

            var result = ((TriangleFactory)shape.GetShape()).IsRectangular();

            Assert.True(result);

        }
        [Fact]
        public void IsNotRectangular()
        {
            var shape = new Shape(new TriangleFactory(3, 3, 5));

            var result = ((TriangleFactory)shape.GetShape()).IsRectangular();

            Assert.False(result);

        }
        [Fact]
        public void RectangleSquare()
        {
            var shape=new Shape(new RectangleFactory(3,4));

            var result=shape.Calculate();

            Assert.Equal(12, result);
        }

    }

}