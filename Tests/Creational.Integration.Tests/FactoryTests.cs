using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Factory;

namespace Creational.Integration.Tests
{
    public class FactoryTests
    {
        [Test]
        public void checkSquareCreation()
        {
            ShapeFactory factory = new ShapeFactory();
            Shape? square = factory.getShape(1);
            Assert.IsNotNull(square);
            Assert.IsInstanceOf<Square>(square);
        }
        [Test]
        public void checkRectangleCreation()
        {
            ShapeFactory factory = new ShapeFactory();
            Shape? rectangle = factory.getShape(2);
            Assert.IsNotNull(rectangle);
            Assert.IsInstanceOf<Rectangle>(rectangle);
        }
        [Test]
        public void checkTriangleCreation()
        {
            ShapeFactory factory = new ShapeFactory();
            Shape? triangle = factory.getShape(3);
            Assert.IsNotNull(triangle);
            Assert.IsInstanceOf<Triangle>(triangle);
        }
    }
}
