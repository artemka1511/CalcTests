using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalc.Tests
{
    [TestFixture]
    class CalculatorTests
    {
        public Calculator calculator = new Calculator();

        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            Assert.That(10 == calculator.Additional(2,8));
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            Assert.That(5 == calculator.Subtraction(10, 5));
        }

        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            Assert.That(64 == calculator.Miltiplication(8, 8));
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            Assert.That(9 == calculator.Division(18, 2));
        }

        [Test]
        public void DivisionMustThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Division(5, 0));
        }
    }
}
