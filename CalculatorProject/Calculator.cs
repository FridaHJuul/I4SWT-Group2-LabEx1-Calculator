using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
   public class Calculator
   {
      public double Add(double A, double B)
      {
         return A + B;
      }

      public double Subtract(double A, double B)
      {
         return A - B;
      }

      public double Multiply(double A, double B)
      {
         return A * B;
      }

      public double Power(double x, double exp)
      {
         return Math.Pow(x, exp);
      }

       public double Divide(double dividend, double divisor)
       {
           try
           {
               return dividend / divisor;
           }
           catch (DivideByZeroException e)
           {
               Console.WriteLine(e.Message);
               throw;
           }
       }
   }
}
