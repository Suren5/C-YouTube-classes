using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];
            // x[0] ..... x[9]
            
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = i * i;
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}