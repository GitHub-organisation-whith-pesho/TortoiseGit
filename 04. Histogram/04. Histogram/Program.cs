using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
           
            decimal p1 = 0;
            decimal p2 = 0;
            decimal p3 = 0;
            decimal p4 = 0;
            decimal p5 = 0;
            
            for (int i = 0; i < n; i++)
            {
                decimal A = decimal.Parse(Console.ReadLine());

                if (A<200)
                {
                    p1 = p1 + 1;
                }
                else if (A>=200 && A < 400)
                {
                    p2 = p2 + 1;
                }
                else if (A >= 400 && A < 600)
                {
                    p3 = p3 + 1;
                }
                else if (A >= 600 && A < 800)
                {
                    p4 = p4 + 1;
                }
                else if (A >= 800)
                {
                    p5 = p5 + 1;
                }
            }

            decimal sum = p1 + p2 + p3 + p4 + p5;
            decimal P1 = (100 / sum) * p1;
            decimal P2 = (100 / sum) * p2;
            decimal P3 = (100 / sum) * p3;
            decimal P4 = (100 / sum) * p4;
            decimal P5 = (100 / sum) * p5;

            Console.WriteLine("{0:0.00} %", P1);
            Console.WriteLine("{0:0.00} %", P2);
            Console.WriteLine("{0:0.00} %", P3);
            Console.WriteLine("{0:0.00} %", P4);
            Console.WriteLine("{0:0.00} %", P5);
            


        }
    }
}
