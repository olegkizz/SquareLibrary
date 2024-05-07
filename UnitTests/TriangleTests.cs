using Moq;
using SquareLibrary;

namespace UnitTests
{
    public class TriangleTests
    {
        [Test]
        public void GetTriangleAreaWithCorrectSides_ReturnsCorrectArea()
        {
            //arrange
            double a = 2;
            double b = 3;
            double c = 4;
            double halfPer = (a + b + c) / 2;
            double areaExpected = Math.Sqrt(halfPer * (halfPer - a) * (halfPer - b)
                   * (halfPer - c));
            Figure _triangle = new Triangle(a,b,c);
            //act
            double result = _triangle.Area();
            //assert
            Assert.AreEqual(areaExpected, result);
        }

        [Test]
        public void 
            GetTriangleAreaWithInCorrectSides_ReturnsTriangleExceptionWithSumOfTwoLinesBiggerThanThird()
        {
            //arrange
            double a = 1;
            double b = 3;
            double c = 4;
            Exception ex = new (); ;
            //act
            try
            {
               Figure _triangle = new Triangle(a, b, c);
            }
            catch (Exception e)
            {
                ex = e;
            }
            //assert
            Assert.IsInstanceOf<TriangleException>(ex);
            Assert.AreEqual("Sum of two lines bigger than third.", ex.Message);
        }
        [Test]
        public void
            GetTriangleAreaWithTwoSides_ReturnsSquareTriangle()
        {
            //arrange
            double a = 1;
            double b = 3;
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double area;
            double halfPer = (a + b + c) / 2;
            double areaExpected = Math.Sqrt(halfPer * (halfPer - a) * (halfPer - b)
                   * (halfPer - c));
            Exception ex = new();
            Figure _triangle = new Triangle(a, b);
            //act
            area = _triangle.Area();
            //assert
            Assert.AreEqual(areaExpected, area);
        }
        [Test]
        public void
           GetSquareTriangle_ReturnsTriangleIsSquare()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            bool isSquare;
            Triangle _triangle = new Triangle(a, b, c);
            //act
            isSquare = _triangle.IsSquare();
            //assert
            Assert.AreEqual(true, isSquare);
        }
        //[Test]
        //public void
        // GetTriangleAreaWithInCorrectSides_ReturnsTriangleExceptionWithSidesCantBeNegative()
        //{
        //    //arrange
        //    double a = -4;
        //    double b = -2;
        //    double c = -3;
        //    Exception ex = new (); ;
        //    //act
        //    try
        //    {
        //        Figure _triangle = new Triangle(a, b, c);
        //    }
        //    catch (Exception e)
        //    {
        //        ex = e;
        //    }
        //    //assert
        //    Assert.IsInstanceOf<TriangleException>(ex);
        //    Assert.AreEqual("Sides cant be negative.", ex.Message);
        //}
    }
}
