using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
       
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("a) Prostopadloscian\nb)stozek");
            
            //cube c1 = new cube(2, 2, 2);
            //Console.WriteLine(c1.Vol());
            //Console.ReadKey();
            int caseSw = int.Parse(Console.ReadLine());
            switch(caseSw)
            {
                case 1:
                    Console.WriteLine("Dimensions:\n a =");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("b = ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("c = ");
                    double c = double.Parse(Console.ReadLine());
                    cube cube1 = new cube1(a, b, c);
                    Console.WriteLine("V = ", cube1.Vol());
                    Console.WriteLine("P = ", cube1.area());
                    
                case 2:
                    Console.WriteLine("Dimensions:\n r =");
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine("H = ");
                    double h = double.Parse(Console.ReadLine());
                    cone cone1 = new cone1(r, h);
                    Console.WriteLine("V = ", cone1.Vol());
                    Console.WriteLine("P = ", cone1.area());
                    


            }
        }
    }
    
    class cube
    {
        int a;
        int b;
        int c;
        public cube()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public cube(int a1, int b1, int c1)
        {
            a = a1;
            b = b1;
            c = c1;
        }
        
        public int Vol()
        {

            return a * b * c;
        }
        public int area()
        {
            return 2 * a * b + 2 * a * c + 2 * b * c;
        }
        
    }
    class cone
    {
        double r;
        double h;
        double l;
        public cone()
        {
            r = 0;
            h = 0;
            l = 0;
        }

        public cone(int r1, int h1, int l1)
        {
            r = r1;
            h = h1;
            l = l1;
        }

        public int Vol()
        {

            return Math.PI / 3 * r * r * h;
        }
        public int area()
        {
            return Math.PI * r + Math.PI * l;

        }
    }  
}