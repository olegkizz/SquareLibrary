using Moq;
using SquareLibrary;

namespace UnitTests
{
    public class CircleTests
    {
        [Test]
        public void GetCircleAreaWithCorrectRadius_ReturnsArea()
        {
            //arrange
            double r = 3;
            double area;
            Figure _circle = new Circle(r);
            //act
            area = _circle.Area();
            //assert
            Assert.That(area, Is.EqualTo(Math.PI * Math.Pow(r, 2)));
        }
        [Test]
        public void GetCircleWithInCorrectRadius_ReturnsExceptionRadiusCantBeNegative()
        {
            //arrange
            double r = -2;
            Exception ex = new ();
            //act
            try
            {
                Figure _circle = new Circle(r);
            } catch(Exception e)
            {
                ex = e;
            }
            //assert
            Assert.IsInstanceOf<CircleException>(ex);
            Assert.AreEqual("Radius cant be negative", ex.Message);
        }
    }
}