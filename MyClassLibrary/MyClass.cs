using System;

namespace MyClassLibrary
{
    public static class MyClass
    {
        public static double Tetrate(double a, int n)
        {
            if (n < 0)
            {
                throw new NotImplementedException("Negative tetration not implemented");
            }

            if (n == 0)
            {
                return 1.0;
            }

            var result = a;
            var logA = Math.Log(a);

            n--;
            while (n > 0)
            {
                result = Math.Exp(logA * result);
                n--;
            }

            return result;
        }
    }
}
