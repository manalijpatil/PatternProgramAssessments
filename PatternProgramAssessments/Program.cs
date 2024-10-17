using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProgramAssessments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q.1>");
            //Q.1)
            //*****
            // ****
            //  ***
            //   **
            //    *
            for(int a = 5; a >= 1; a--)
            {
                for(int b=1;b<=a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Q.2>");
            /*
             *Q.2) Print pattern 
                1 
                12 
                123 
                1234 
                12345 
                1234 
                123
                12 
                1
             */
            for (int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            for(int i=5-1; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }


            Console.WriteLine("Q.3>");
            /*
             * 3) Print pattern 
                1 
                121 
                12321 
                1234321 
                123454321 
                1234321 
                12321 
                121 
                1 
             */
        }
    }
}
