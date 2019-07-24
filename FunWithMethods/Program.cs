using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Methods *****\n");
            // Pass two variables in by value.
            int x = 9, y = 10;            
            Add(x, y, out int ans);
            Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            Console.WriteLine("Answer is: {0}", ans);
            Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
        }

        static void Add(int x, int y, out int ans)
        {
            ans = x + y;           
        }
    }
}
