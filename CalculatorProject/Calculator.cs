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
         if (x < 0 && exp % 1 != 0)
         {
            throw new Exception("Not a real number");
         }
         else
         return Math.Pow(x, exp);
      }
   }
}
