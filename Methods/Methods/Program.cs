using System;


namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double x = 49,y;
            y = Math.Sqrt(x);
            Console.WriteLine(y);

            double a=2, b=32, c;
            c = Math.Pow(a, b);
            Console.WriteLine(c);
            
            */
            /*
            int x=2, y=8, z;
            z = Gumar(x, y);
            Console.WriteLine(z);

            Havasar(x, y);
            */
                int x = 2;
            Qarakusi(ref x);
            Console.WriteLine(x);

            int a = 5, b = 11, c;
            int sum = 0, min = 0;

            Hashvel(a, b, out sum, out min);

            Console.WriteLine("sum= "+sum);
            Console.WriteLine("min= "+min);

            Console.ReadLine();
        }
        static void Hashvel(int a, int b, out int sum, out int min)
        {
            sum = a + b;
            min = a - b;
        }
        static void Qarakusi(int x) // call by value
        {
            x = x * x;
            Console.WriteLine(x);
        }
        static void Havasar(int x, int y)
        {
            if (x == y) Console.WriteLine("Havasar en");
            else Console.WriteLine("Havasar chen");
        }

        static int Gumar(int x, int y)
        {
            int z = x + y;
            return z;
        }

        static int Gumar(int x, int y)
        {
            int z = x + y;
            return z;
        }
    }
}
// void F1() {....}
// void F2(int x) {....}
// int F3() {...}
// int F4(int x, char ch) {...}
