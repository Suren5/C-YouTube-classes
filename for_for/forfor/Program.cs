using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_for
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i<10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(" " + (i+j)); 
                    // 0 0 //0 1// 0 2 //0 3// ... //0 9
                    //1 0 //1 1 //1 2 ... //9 9
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
// break continue
// 20-30 50-60
// for - while do while