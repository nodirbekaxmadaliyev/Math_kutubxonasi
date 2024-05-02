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

        public List<long> Tub(int n)
        {
            var tubNumbers = new List<long>();
            for (int i = 2; i <= n; i++)
                if (IsTub(i)) tubNumbers.Add(i);
            return tubNumbers;
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
        public List<long> Fibonachi(long a, long b)
        {
            List<long> fibos = new List<long>();
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
                fibos.Add(c);
                c = a1 + a2;
                a1 = a2;
                a2 = c;
            }
            return fibos;
        }
        public List<long> Fibonachi(long a1, long a2, int n)
        {
            var fibos = new List<long>();
            fibos.Add (a1); 
            fibos.Add (a2);
                long c;
                while (n -- > 2)
                {
                    c = a1 + a2;
                    fibos.Add (c);
                    a1 = a2;
                    a2 = c;
                }
            return fibos;
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
