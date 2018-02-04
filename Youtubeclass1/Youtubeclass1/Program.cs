using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtubeclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello C#");
            int x, y, z;
            Console.Write("Insert x - ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Insert y - ");
            y = int.Parse(Console.ReadLine());
            z = x + y;
            Console.WriteLine("Sum=" + z);

            // Data type ranges: int, long, short, byte
            // float, double
            // char, string
            // bool
            */
            
            
            int x;
            int a, b, c, d, z;
            Console.Write("Mutqagreq qaranish x - ");
            x = int.Parse(Console.ReadLine());

            
            // a = 10 / 3; //3
                // b = 10 % 3; //1

             a = x / 1000; //4
             b = x / 100 % 10; //45 -5
             c = x / 10 % 10; //452 - 2
             d = x % 10; //6

            z = a + b + c + d;
            Console.WriteLine("Gumar@ = " + z);

            Console.ReadLine();
        }
    }
}
