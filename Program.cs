using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_RecursivePrintSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int n;
            bool validEntry1 = true;
            bool validEntry2 = true;
            Console.WriteLine(" ==== LA 27 - Recursive Print Series ====\n" +
                "Equation (x,n) = 1 + x + x² + ... + xⁿ");
            while(validEntry1 && validEntry2)
            { 
                Console.Write("\nWhat is the value of the base, x? ");
                bool validInt1 = int.TryParse(Console.ReadLine(), out x);
                if (validInt1)
                {
                        while (validEntry2)
                        { 
                        Console.Write("What is the highest value of the coefficient, n? ");
                        bool validInt2 = int.TryParse(Console.ReadLine(), out n);
                            if (validInt2)
                            {
                                validEntry1 = false;
                                Console.WriteLine("The summary of the equation is " + Equation(x, n));
                                break;
                            }
                            else
                                Console.WriteLine("\nPlease enter a valid number. ");
                        }
                }
                else
                    Console.WriteLine("\nPlease enter a valid number. ");
            }
            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadLine();
        }
        public static int Equation(int a, int b)
        {
            int term = Convert.ToInt32(Math.Pow(a, b));
             

             if (b == 0)
                return 1;
             else
                return term + Equation(a, b - 1);

        }

    }
}
