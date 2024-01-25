using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_csharp
{
    internal class Program
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }


        public static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }


        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;

            int res = add(150, 10);

            Console.WriteLine(res);


            Func<int, int, int, int> add3 = Sum;

            res = add3(150, 20, 30);

            Console.WriteLine(res);


            Console.ReadLine();

            // C# Func Linq Where


        }
    }
}



