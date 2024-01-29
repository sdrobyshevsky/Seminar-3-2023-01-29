using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

    public class Calculator
    {
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            return a / b;
        }
    }

    [TestFixture]
    public class CalculatorTests2
    {
        [TestMethod]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            Calculator2 calculator = new Calculator2();

            // Act and Assert
            NUnit.Framework.Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0));
        }
    }