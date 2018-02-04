using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE
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

            int max = 0;
            if (x > y && x > z)
            { 
                max = x;
            }
            if (y > x && y > z)
            {
                max = y;
            }
            if (z > x && z > y)
            {
                max = z;
            }
            Console.WriteLine("max=" + max);
            Console.ReadLine();


        }
    }
}
