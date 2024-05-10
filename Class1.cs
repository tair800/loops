using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    public class Class1
    {
        int count = 0;
        public int OddNum(int m,int n)
        {
            for (int i = n; i < m; i++)
            {
                if (i % 2 == 1)
                {
                    count++;
                }
            }
            return count;
        }
        static bool PrimeNum(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            if (n <= 3)
            {
                return true;
            }

            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
        static int CountFloors(int n)
        {
            int count = 0;
            while (n != 0)
            {
                n /= 10;
                count++;
            }
            return count;
        }
    }
}
