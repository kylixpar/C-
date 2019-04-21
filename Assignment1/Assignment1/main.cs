using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            soNT(n);
            Console.WriteLine(fibonacci(n));
        }
        public static void soNT(int n)
        {
            bool flag;
            for (int i = 2; i < n; i++)
            {
                flag = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static int fibonacci(int n)
        {
            int sum = 0;
            int n1 = 1, n2 = 0, temp;
            
            for (int i = 0; i < n - 1; i++)
            {
                sum += n1;
                temp = n1;
                n1 += n2;
                n2 = temp;
            }
            return sum;
        }

       
    }
}
