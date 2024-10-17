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
            for(int i= 1; i <= 5; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(j);
                }
                for(int j = i - 1; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            for(int i = 5 - 1; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for(int j = i - 1; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Q.4>");
               //4)
               //      1
               //     1 2
               //    1 2 3
               //   1 2 3 4
               //  1 2 3 4 5
               // 1 2 3 4 5 6
               //1 2 3 4 5 6 7

            for (int i = 1; i <= 7; i++)
            {
                for (int j = i; j < 7; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Q.5>");
            /* 5)
                   1      1
                  2 2
                 3 3 3
                4 4 4 4
               5 5 5 5 5
              6 6 6 6 6 6
             7 7 7 7 7 7 7
          */
            for (int i = 1; i <= 7; i++)
            {
                for (int j = i; j < 7; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Q.6>");
            /*
             * 6. WAP to print following Pattern
                *
                * *
                * * *
                * * * *
                * * * * *
                * * * * *
                * * * *
                * * *
                * *
                *
             */
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(int i = 5; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Q.7>");
            /*
             * 7) WAP to print following Pattern
                    *
                   * *
                  * * *
                 * * * *
                * * * * *
                 * * * *
                  * * *
                   * *
                    *
             */
            
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
             for (int i = n - 1; i >= 1; i--)
                {
                    for (int j = n; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    // Print stars with spaces in between
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }

        Console.WriteLine("Q.8>");
            /*
             8)     WAP to print following Pattern
                    1 0 1 0 1
                    0 1 0 1 0
                    1 0 1 0 1
                    0 1 0 1 0
                    1 0 1 0 1

             */
            for(int i= 0; i<5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
               
                Console.WriteLine();
            }

            Console.WriteLine("Q.9>");

            /*
             * 9)        ab
                       ababab
                      ababababab

             */

           
            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("ab");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Q.10>");
            /*
             * 10)
                    Generate your own function to satisfy the relationship between the inputs and outputs.
                    Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.
                    Examples
                    832 ➞ 594
                    51 ➞ 36
             */
            Console.WriteLine("Enter the input:");
            int input = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            int temp = input;
            while (input != 0)
            {
                int rem = input % 10;
                rev = rev * 10 + rem;
                input = input / 10;
            }
            Console.WriteLine("reverse="+rev);
            //int sub = input - rev;
            //Console.WriteLine(sub);
            //if (temp == rev)
            //{
            //    Console.WriteLine(input+"-->"+(input - rev));
            //}
        }
    }
}
