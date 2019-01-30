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
         result= Math.Pow(x, exp);
         Accumulator = result;
         return result;
      }
   }
}
