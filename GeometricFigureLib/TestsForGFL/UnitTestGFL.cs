using NUnit.Framework;
using GeometricFigureLib;

namespace TestsForGFL
{
    public class Tests
    {
        [Test]
        public void TestBuildException()
        {
            Assert.Catch(() => FigureBuilder.Build(1, 1, 25));
            // Assert.That(() => FigureBuilder.Build(1, 1, 25), Throws.Exception);
        }
        
        [Test]
        public void TestBuildTriangle()
        {
            var t = FigureBuilder.Build(9, 16, 25);
            Assert.AreEqual(new Triangle(9, 16, 25), t);
        }
        
        [Test]
        public void TestBuildCircle()
        {
            var t = FigureBuilder.Build(5);
            Assert.AreEqual(new Circle(5), t);
        }
        
        [Test]
        public void TestRight1()
        {
            var t = FigureBuilder.Build(3, 4, 5);
            Assert.True(t.IsRight());
        }
        
        [Test]
        public void TestRight2()
        {
            var t = FigureBuilder.Build(6, 8, 10);
            Assert.True(t.IsRight());
        }
        
        [Test]
        public void TestRight3()
        {
            var t = FigureBuilder.Build(3, 4, 3);
            Assert.False(t.IsRight());
        }
    }
}