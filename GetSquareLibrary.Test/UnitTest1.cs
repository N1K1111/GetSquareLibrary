using NUnit.Framework;

namespace GetSquareLibrary.Test
{
    public class Tests
    {
        [Test]
        public void GetSquareCircle()
        {
            // arrange
            double a = 10;
            double expected = 31.415927;

            // act
            Shape shape = new Shape(a);
            double actual = shape.Square;

            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetSquareTriangle()
        {
            //arrange 
            double a = 4;
            double b = 5;
            double c = 3;
            double expected = 6;

            // act
            Shape shape = new Shape(a, b, c);
            double actual = shape.Square;

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetRectangularTriangle()
        {
            //arrange 
            double a = 4;
            double b = 5;
            double c = 3;
            bool expected = true;

            // act
            Shape shape = new Shape(a, b, c);
            bool actual = shape.GetRectangularTriangle(a, b, c);

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}