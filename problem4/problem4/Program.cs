using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem4
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
            int a, b, c, d, e;
            Console.Write("Mutqagreq hnganish x - ");
            x = int.Parse(Console.ReadLine());




            a = x / 10000; //4
            b = x / 1000 % 10; //45 -5
            c = x / 100 % 10; //452 - 2
            d = x / 10 % 10; //6
            e = x % 10;

            // 42524 - simetrik tiv e
            
           
            if (a == e && b == d) Console.WriteLine(x + " - Tivy simetrik e");
            else Console.WriteLine(x + " - Tivy simetrik che");
            Console.ReadLine();
        }
    }
}
