using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FractionTests
{
    [TestClass()]
    public class FractionTestsStaticMethods
    {
        [TestMethod()]
        public void Add_NullOperand_ShouldReturnNull()
        {
            Fraction.Fraction fractionA = new Fraction.Fraction(3, 4);
            Fraction.Fraction result = Fraction.Fraction.Add(fractionA, null);
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void Add_OperandInvalid_ShouldReturnNull()
        {
            Fraction.Fraction fractionA = new Fraction.Fraction(3, 4);
            Fraction.Fraction fractionB = new Fraction.Fraction();
            Fraction.Fraction result = Fraction.Fraction.Add(fractionA, fractionB);
            Assert.IsNull(result);
        }

        [TestMethod()]
        public void Add_WithoutShorten_ShouldReturnCorrectResult()
        {
            Fraction.Fraction fractionA = new Fraction.Fraction(3, 4);
            Fraction.Fraction fractionB = new Fraction.Fraction(5, 7);
            Fraction.Fraction result = Fraction.Fraction.Add(fractionA, fractionB);
            Assert.AreEqual(41, result.Numerator, "Einfache Addition: Numerator fehlerhaft");
            Assert.AreEqual(28, result.Denominator, "Einfache Addition: Denominator fehlerhaft");
        }

        [TestMethod()]
        public void Add_WithShorten_ShouldReturnCorrectResult()
        {
            Fraction.Fraction fractionA = new Fraction.Fraction(3, 4);
            Fraction.Fraction fractionB = new Fraction.Fraction(5, 6);
            Fraction.Fraction result = Fraction.Fraction.Add(fractionA, fractionB);
            Assert.AreEqual(19, result.Numerator, "Einfache Addition: Numerator fehlerhaft");
            Assert.AreEqual(12, result.Denominator, "Einfache Addition: Denominator fehlerhaft");
        }

        [TestMethod()]
        public void Sub_WithoutShorten_ShouldReturnCorrectResult()
        {
            Fraction.Fraction fractionA = new Fraction.Fraction(3, 4);
            Fraction.Fraction fractionB = new Fraction.Fraction(5, 7);
            Fraction.Fraction result = Fraction.Fraction.Sub(fractionA, fractionB);
            Assert.AreEqual(1, result.Numerator);
            Assert.AreEqual(28, result.Denominator);
        }

        [TestMethod()]
        public void Sub_WithShorten_ShouldReturnCorrectResult()
        {
            Fraction.Fraction fractionA = new Fraction.Fraction(3, 4);
            Fraction.Fraction fractionB = new Fraction.Fraction(5, 6);
            Fraction.Fraction result = Fraction.Fraction.Sub(fractionA, fractionB);
            Assert.AreEqual(-1, result.Numerator);
            Assert.AreEqual(12, result.Denominator);
        }

        [TestMethod()]
        public void Mult_WithoutShorten_ShouldReturnCorrectResult()
        {
            Fraction.Fraction fractionA = new Fraction.Fraction(3, 4);
            Fraction.Fraction fractionB = new Fraction.Fraction(5, 7);
            Fraction.Fraction result = Fraction.Fraction.Mult(fractionA, fractionB);
            Assert.AreEqual(15, result.Numerator);
            Assert.AreEqual(28, result.Denominator);
        }

        [TestMethod()]
        public void Mult_WithShorten_ShouldReturnCorrectResult()
        {
            Fraction.Fraction fractionA = new Fraction.Fraction(3, 4);
            Fraction.Fraction fractionB = new Fraction.Fraction(5, 6);
            Fraction.Fraction result = Fraction.Fraction.Mult(fractionA, fractionB);
            Assert.AreEqual(5, result.Numerator);
            Assert.AreEqual(8, result.Denominator);
        }


        [TestMethod()]
        public void Div_WithoutShorten_ShouldReturnCorrectResult()
        {
            Fraction.Fraction fractionA = new Fraction.Fraction(3, 4);
            Fraction.Fraction fractionB = new Fraction.Fraction(5, 7);
            Fraction.Fraction result = Fraction.Fraction.Div(fractionA, fractionB);
            Assert.AreEqual(21, result.Numerator);
            Assert.AreEqual(20, result.Denominator);
        }

        [TestMethod()]
        public void Div_WithShorten_ShouldReturnCorrectResult()
        {
            Fraction.Fraction fractionA = new Fraction.Fraction(3, 4);
            Fraction.Fraction fractionB = new Fraction.Fraction(5, 6);
            Fraction.Fraction result = Fraction.Fraction.Div(fractionA, fractionB);
            Assert.AreEqual(9, result.Numerator);
            Assert.AreEqual(10, result.Denominator);
        }
    }
}
