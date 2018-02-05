using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] x = new int[20];
            //int[] y = new int[20];

            /*
            //int[] x= {5, 12, -9, 6, 58, 4, 3, -8}
            // x[0] .....x[9]
            Random r = new Random(); 
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = r.Next(100);
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
            
            //////////////// gumar /////
            int s = 0; 
            for (int i = 0; i < x.Length; i++)
            {
                s += x[i];
            }
            Console.WriteLine("Sum = " + s);


            ////////////// zuig tveri gumar ev qanak /////
            s = 0;          // gumar
            int q = 0;      // qanak
            for (int i=0; i<x.Length; i++)
            {
                if(x[i]%2==0)
                {
                    s = s + x[i];
                    q++; 

                }
            }
            Console.WriteLine("Zuig tveri gumar@ = " +s);
            Console.WriteLine("Zuig tveri qanak@ = " + q);

            //// y -zangvac x-zuig tveric
            int j = 0;


            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] % 2 == 0)
                {
                    y[j] = x[i];
                    j++;

                }

            }
            Console.WriteLine("Print y - array");
            for (int i = 0; i <j; i++)
            {
                Console.Write(y[i] + " ");
            }
                Console.WriteLine();
                */
            Random r = new Random();
            int[,] x = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    x[i, j] = r.Next(10, 100);
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(x[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
