using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_kutubxonasi
{
    internal class Math_lib
    {
        public bool IsTub(long n)
        {
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }

        public void Tub(int n)
        {
            Console.WriteLine($"[1, {n}] oraliqdagi tub sonlar :");
            for (int i = 1; i <= n; i++)
                if (IsTub(i)) Console.Write(i + " ");
            Console.WriteLine();
        }           

        public bool Fibonachi(long n)
        {
            if (n < 4) return true;
            long a = 0, b = 1, c = a + b;
            while (c < n)
            {
                c = a + b;
                a = b;
                b = c;
            }
            if (c == n) return true;
            return false;
        }
        public void Fibonachi(long a, long b)
        {
            Console.WriteLine($"\t[{a}, {b}] oraliqdagi fibonachi sonlar : ");
            if (a > b) (a, b) = (b, a);
            long a1 = 0, a2 = 1, c = a1 + a2;
            while(c < a)
            {
                c = a1 + a2;
                a1 = a2;
                a2 = c;
            }
            while(c <= b)
            {
                Console.Write(c + " ");
                c = a1 + a2;
                a1 = a2;
                a2 = c;
            }
        }
        public void Fibonachi(long a1, long a2, int n)
        {
            Console.WriteLine($"\tBerilgan boshlang'ich qiymatlar bilan {n} ta fibonachi son :");
            if (n < 2) Console.WriteLine(a1);
                else 
            {
                Console.Write($"{a1}, {a2} ");
                long c;
                while (n -- > 2)
                {
                    c = a1 + a2;
                    Console.Write(c + " ");
                    a1 = a2;
                    a2 = c;
                }
            }
            Console.WriteLine();
        }
        public double Pow(double a, int n)
        {
            if (n == 0) return 1;
            double c = a;
            while (n -- > 1)
            {
                c *= a;
            }
            return c;
        }
        public bool IsPerfect(long a)
        {
            if(a < 2) return false;
            long sum = 1, i = 2;
            for (; i * i < a; i ++)
                if (a % i == 0)
                    sum += i + (a / i);
            if (i * i == a) sum += i;
            if (sum == a) return true;
            return false;            
        }
            
    }
}
