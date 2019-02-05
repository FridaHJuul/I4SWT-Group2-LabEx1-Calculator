using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
         uut = new Calculator();
      }

      [TestCase(2.1, 3.4, 5.5)]
      [TestCase(-2.1, 3.4, 1.3)]
      [TestCase(-2.1, -3.4, -5.5)]
      [TestCase(0, 2.1, 2.1)]
      [TestCase(-2.1, 0, -2.1)]
      [TestCase(2, 4, 6)]
      [TestCase(0, 4, 4)]
      public void Add_AddNumber1AndNumber2_EqualsNumber3(double number1, double number2, double number3)
      {
         Assert.That(Math.Round(uut.Add(number1, number2), 2), Is.EqualTo(number3));
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

      [TestCase(4, 2, 2)]
      [TestCase(-5, -5, 1)]
      [TestCase(-5, 1, -5)]
      [TestCase(10, -2, -5)]
      [TestCase(0, 2, 0)]
      public void Divide_DivideNumber1WithNumber2_EqualsNumber3(double number1, double number2, double number3)
      {
         Assert.That(Math.Round(uut.Divide(number1, number2), 3), Is.EqualTo(number3));
      }

      [Test]
      public void Divide_DivisionByZero_ThrowsException()
      {
         var ex = Assert.Catch<DivideByZeroException>(() => uut.Divide(6, 0));
         StringAssert.Contains("Division by zero not possible", ex.Message);
      }

      [Test]
      public void Accumulator_AddIsCalled_AccumulatorIsEqualToResultOfAddMethod()
      {
         uut.Add(3, 4);
         Assert.That(uut.Accumulator, Is.EqualTo(uut.Add(3, 4)));
      }

      [Test]
      public void Accumulator_SubtractIsCalled_AccumulatorIsEqualToResultOfSubtractMethod()
      {
         uut.Subtract(5, 1);
         Assert.That(uut.Accumulator, Is.EqualTo(uut.Subtract(5, 1)));
      }

      [Test]
      public void Accumulator_MultiplyIsCalled_AccumulatorIsEqualToResultOfMultiplyMethod()
      {
         uut.Multiply(3, 55);
         Assert.That(uut.Accumulator, Is.EqualTo(uut.Multiply(3, 55)));
      }

      [Test]
      public void Accumulator_PowerIsCalled_AccumulatorIsEqualToResultOfPowerMethod()
      {
         uut.Power(2, -4);
         Assert.That(uut.Accumulator, Is.EqualTo(uut.Power(2, -4)));
      }

      [Test]
      public void Accumulator_Call2Methods_AccumulatorIsEqualToTheResultOfLastCalledMethod()
      {
         uut.Add(3, 6);
         uut.Subtract(8, 6);
         Assert.That(uut.Accumulator, Is.EqualTo(uut.Subtract(8, 6)));
      }

      [Test]
      public void Power_RaiseNegativeNumberToNonInteger_ExceptionNotARealNumber()
      {
         var ex = Assert.Catch<Exception>(() => uut.Power(-2, 3.1));
         StringAssert.Contains("Not a real number", ex.Message);
      }
   }
}
