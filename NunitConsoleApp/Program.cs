using MyClassLibrary;
using NUnit.Framework;

namespace NunitConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            MyClass.Tetrate(1d, 2);
            var test = new MyClassTests();
            test.TetrationTests(1d, 2, 1d);
            Assert.AreEqual(1, 2);
        }
    }
}
