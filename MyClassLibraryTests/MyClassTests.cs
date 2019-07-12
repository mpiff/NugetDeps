using System;
using NUnit.Framework;

namespace MyClassLibrary
{
    [TestFixture]
    public class MyClassTests
    {
        [Test]
        [TestCase(1.0, 0, 1.0)]
        [TestCase(1.0, 1, 1.0)]
        [TestCase(1.0, 2, 1.0)]
        [TestCase(2.0, 0, 1.0)]
        [TestCase(2.0, 1, 2.0)]
        [TestCase(2.0, 2, 4.0)]
        [TestCase(2.0, 3, 16.0)]
        [TestCase(2.0, 4, 65536.0)]
        [TestCase(3.0, 0, 1.0)]
        [TestCase(3.0, 1, 3.0)]
        [TestCase(3.0, 2, 27.0)]
        [TestCase(3.0, 3, 7625597484987.0)]
        [TestCase(4.0, 0, 1.0)]
        [TestCase(4.0, 1, 4.0)]
        [TestCase(4.0, 2, 256.0)]
        [TestCase(4.0, 3, 1.3407807929942597e154)]
        public void TetrationTests(double a, int n, double expected)
        {
            const double epsilon = 0.0000000000001;

            var actual = MyClass.Tetrate(a, n);
            var difference = Math.Abs((actual / expected) - 1);
            Assert.That(difference, Is.LessThan(epsilon));
        }
    }
}
