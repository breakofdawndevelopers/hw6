using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{
    class ForLoop
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int intVar1, intVar2, multiplyValues, count = 0;
            double divideValues;
            for (count = 1; count <= 10; count++)
            {
                try
                {
                    Console.WriteLine("Iteration {0}", count);
                    intVar1 = rnd.Next(0, 11);
                    intVar2 = rnd.Next(0, 11);
                    multiplyValues = intVar1 * intVar2;
                    divideValues = Math.Round(((double) intVar1 / intVar2), 2);
                    Console.WriteLine("Product of " + intVar1 + " * " + intVar2 + " = " + multiplyValues);
                    Console.WriteLine("Quotient of " + intVar1 + " / " + intVar2 + " = " + divideValues);
                }
                catch (DivideByZeroException dEx)
                {
                    Console.WriteLine("Divide By Zero Exception Caught!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("General Exception Caught");
                }
                finally
                {
                    Console.WriteLine();
                }
            } Console.ReadLine();
        }
    }
}





                
               
                    