using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodopg11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 16;
            int numberTwo = 5;

            // 11.1 return the sum 
            Console.WriteLine(Logic.Sum(numberOne, numberTwo));
            Console.WriteLine();

            // 11.2 return two numbers divided by each other

            Console.WriteLine(Logic.Divided(numberOne, numberTwo));
            Console.WriteLine();

            // 11.3 
            Console.WriteLine(Logic.Modulus(numberOne, numberTwo));
            Console.WriteLine();

            //11.4

            List<int> liste = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine(liste.Max());

            Console.WriteLine(Logic.BiggestElement(liste));


           Console.WriteLine(Logic.BiggestElement(liste));



            //11.5 

            List<string> listing = new List<string> { "a", "b", "c", "x"};
            

            Logic.DoesItContain(listing);

            if (Logic.DoesItContain(listing) == true)
            {
                Console.WriteLine("true");
            }

            else if (Logic.DoesItContain(listing) == false)
            {
                Console.WriteLine("false");
            }

            //11.6 
           
            List<int> listOfNumbers = new List<int> { 10, 10, 10, 10 };
            double howmanynumbers = listOfNumbers.Count;
            double sum = listOfNumbers.Sum();
            
            Console.WriteLine(Logic.FindAverge(listOfNumbers, howmanynumbers, sum));

            
        }
    }
}
