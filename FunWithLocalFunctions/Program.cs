using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int AddWrapper(int x, int y)
        {
            //Do some validation here
            return Add();
            int Add()
            {
                return x + y;
            }
        }

        static double Add(double x, double y)
        {
            return x + y;
        }

        static long Add(long x, long y)
        {
            return x + y;
        }
    }
}
