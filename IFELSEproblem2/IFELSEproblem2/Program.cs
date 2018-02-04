using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFELSEproblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("Mutqagreq x - ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Mutqagreq y - ");
            y = int.Parse(Console.ReadLine());

            Console.Write("Mutqagreq z - ");
            z = int.Parse(Console.ReadLine());

            if(x == y || y == z || z == x)
            {
                Console.WriteLine("Havasar tver kan")
            }
            else
            {
                Console.WriteLine("Havasar tver chkan")
            }

            Console.ReadLine();


        }
    }
}
