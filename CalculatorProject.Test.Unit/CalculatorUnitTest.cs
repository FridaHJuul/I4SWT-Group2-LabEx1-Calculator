using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CalculatorProject.Test.Unit
{
   [TestFixture]
    public class CalculatorUnitTest
   {
      private Calculator uut;

      [SetUp]
      public void SetUp()
      {
         uut= new Calculator();
      }

      [TestCase(2.1, 3.4, 5.5)]
      [TestCase(-2.1, 3.4, 1.3)]
      [TestCase(-2.1, -3.4, -5.5)]
      [TestCase(0, 2.1, 2.1)]
      [TestCase(-2.1, 0, -2.1)]
      [TestCase(2,4,6)]
      public void Add_AddNumber1AndNumber2_EqualsNumber3(double number1, double number2, double number3)
      {
         Assert.That(Math.Round(uut.Add(number1, number2),2),Is.EqualTo(number3));
      }

      [TestCase(2.1, 3.4, -1.3)]
      [TestCase(-2.1, 3.4, -5.5)]
      [TestCase(-2.1, -3.4, 1.3)]
      [TestCase(0, 2.1, -2.1)]
      [TestCase(-2.1, 0, -2.1)]
      public void Subtract_SubtractNumber2FromNumber1_EqualsNumber3(double number1, double number2, double number3)
      {
         Assert.That(Math.Round(uut.Subtract(number1, number2), 2), Is.EqualTo(number3));
      }

      [TestCase(2.1, 3.4, 7.14)]
      [TestCase(-2.1, 3.4, -7.14)]
      [TestCase(-2.1, -3.4, 7.14)]
      [TestCase(0, 2.1, 0)]
      [TestCase(-2.1, 0, 0)]
      public void Multiply_MultiplyNumber1AndNumber2_EqualsNumber3(double number1, double number2, double number3)
      {
         Assert.That(Math.Round(uut.Multiply(number1, number2), 2), Is.EqualTo(number3));
      }

      [TestCase(2.1, 3.4, 12.461)]
      [TestCase(-2, 2, 4)] 
      [TestCase(2.1, -3.4, 0.08)]
      [TestCase(0, 2.1, 0)]
      [TestCase(-2.1, 0, 1)]
      public void Power_RaiseNumber1ToPowerNumber2_EqualsNumber3(double number1, double number2, double number3)
      {
         Assert.That(Math.Round(uut.Power(number1, number2), 3), Is.EqualTo(number3));
      }

   }
}
