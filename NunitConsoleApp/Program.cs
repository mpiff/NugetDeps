using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            MyClass.Tetrate(1d, 2);
            var test = new MyClassTests();
            test.TetrationTests(1d, 2, 1d);
        }
    }
}
