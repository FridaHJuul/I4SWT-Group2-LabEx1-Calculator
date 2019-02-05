using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
   public class Calculator
   {
      private double result;
      public double Accumulator { get; private set; }
      public double Add(double A, double B)
      {
         result = A + B;
         Accumulator = result;
         return result;
      }

      public double Subtract(double A, double B)
      {
         result= A - B;
         Accumulator = result;
         return result;
      }

      public double Multiply(double A, double B)
      {
         result= A * B;
         Accumulator = result;
         return result;
      }

      public double Power(double x, double exp)
      {
         if (x < 0 && exp % 1 != 0)
         {
            throw new Exception("Not a real number");
         }
         else
         result = Math.Pow(x, exp);
         Accumulator = result;
         return result;
      }

       public double Divide(double dividend, double divisor)
       {
           if (divisor == 0)
           {
               throw new DivideByZeroException("Division by zero not possible");
           }
           else
           {
               return dividend / divisor;
            }
       }
   }
}
