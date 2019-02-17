using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodopg11
{
    class Logic
    {
        //11.1 return the sum of 2 numbers
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        //11.2 divide to numbers 

        public static int Divided(int a, int b)
        {
            return a / b;
        }

        // 11.3

        public static double Modulus(double a, double b)
        {
            double howmany = a / b;
            double remainder = a % b;

            return howmany + remainder;
        }

        // 11.4 

        public static List<int> BiggestElement(List<int> A)
        {
            Console.WriteLine(A.Max()); 

            return A;
        }

        public static bool DoesItContain(List<string> A) //11.5 checks if a certain element is in our list 
        {
            bool contains = true;
            if (A.Contains("x"))
            {
               contains = true;
                 
            }

            else if (!A.Contains("x"))
            {
                contains = false;
             
            }

            return contains;
        }

        // 11.6
        public static double FindAverge(List<int> A, double howmanynumbers, double sum)
        {
            
            double getit = howmanynumbers / sum ;
           

            return getit; 
        }

    }
}
