using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5; //This is a dummy variable//
            double y = 2.75; //This is the second dummy variable//
            decimal z = 1.767879M; //This is a dummy decimal//

            Console.WriteLine("{0} {1} {2}", x, y, z);
            Console.WriteLine($"{x} {y:f1} {z}");
        }
    }
}
