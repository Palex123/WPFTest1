using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0, z = 0;
            i += Increment(ref i);
            z += z++;
            Console.WriteLine(i);
            Console.ReadKey();
        }

        public static int Increment(ref int s)
        {
            return s++;
        }
    }
}
