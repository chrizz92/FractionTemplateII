using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FractionTests
{
    [TestClass()]
    public class FractionTestsSimple
    {
        [TestMethod()]
        public void GetNumerator_SetNumerator_ShouldReturnSettedValue()
        {
            Fraction.Fraction fraction = new Fraction.Fraction();
            fraction.Numerator=3;
            Assert.AreEqual(3, fraction.Numerator);
        }

        [TestMethod()]
        public void GetDenominator_SetDenominator_ShouldReturnSettedValue()
        {
            Fraction.Fraction fraction = new Fraction.Fraction();
            fraction.Denominator=3;
            Assert.AreEqual(3, fraction.Denominator);
        }

        [TestMethod()]
        public void IsValid_SetOnlyNumerator_ShouldReturnInvalid()
        {
            Fraction.Fraction fraction = new Fraction.Fraction();
            fraction.Numerator=3;
            Assert.IsFalse(fraction.IsValid);
        }

        [TestMethod()]
        public void IsValid_SetNumeratorAndDenominator_ShouldReturnValid()
        {
            Fraction.Fraction fraction = new Fraction.Fraction();
            fraction.Numerator=3;
            fraction.Denominator=4;
            Assert.IsTrue(fraction.IsValid);
        }

        [TestMethod()]
        public void IsValid_DenominatorTo0_ShouldReturnInvalid()
        {
            Fraction.Fraction fraction = new Fraction.Fraction();
            fraction.Numerator = 3;
            fraction.Denominator = 4;
            fraction.Denominator = 0;
            Assert.IsFalse(fraction.IsValid);
        }

        [TestMethod()]
        public void IsEqual_DenominatorTo0_ShouldReturnFalse()
        {
            Fraction.Fraction fraction1 = new Fraction.Fraction();
            fraction1.Numerator = 3;
            fraction1.Denominator = 0;
            Fraction.Fraction fraction2 = new Fraction.Fraction();
            fraction2.Numerator = 5;
            fraction2.Denominator = 6;
            Assert.IsFalse(fraction1.IsEqual(fraction2));
        }

        [TestMethod()]
        public void IsEqual_FractionIsNull_ShouldReturnFalse()
        {
            Fraction.Fraction fraction1 = new Fraction.Fraction();
            fraction1.Numerator = 3;
            fraction1.Denominator = 2;
            Assert.IsFalse(fraction1.IsEqual(null));
        }

        [TestMethod()]
        public void IsEqual_Ident_ShouldReturnTrue()
        {
            Fraction.Fraction fraction1 = new Fraction.Fraction();
            fraction1.Numerator = 3;
            fraction1.Denominator = 2;
            Fraction.Fraction fraction2 = new Fraction.Fraction();
            fraction2.Numerator = 3;
            fraction2.Denominator = 2;
            Assert.IsTrue(fraction1.IsEqual(fraction2));
        }

        [TestMethod()]
        public void IsEqual_ShortenIsEqual_ShouldReturnTrue()
        {
            Fraction.Fraction fraction1 = new Fraction.Fraction();
            fraction1.Numerator = 3;
            fraction1.Denominator = 2;
            Fraction.Fraction fraction2 = new Fraction.Fraction();
            fraction2.Numerator = 6;
            fraction2.Denominator = 4;
            Assert.IsTrue(fraction1.IsEqual(fraction2));
        }

        [TestMethod()]
        public void GetNumerator_FractionCannotBeShortened_ShouldReturnOriginalValue()
        {
            Fraction.Fraction fraction = new Fraction.Fraction();
            fraction.Numerator=8;
            fraction.Denominator=19;
            Assert.AreEqual(8, fraction.Numerator);
        }

        [TestMethod()]
        public void GetDenominator_FractionCannotBeShortened_ShouldReturnOriginalValue()
        {
            Fraction.Fraction fraction = new Fraction.Fraction();
            fraction.Numerator=8;
            fraction.Denominator=19;
            Assert.AreEqual(19, fraction.Denominator);
        }

        [TestMethod()]
        public void GetNumerator_FractionCanBeShortened_ShouldReturnShortenedValue()
        {
            Fraction.Fraction fraction = new Fraction.Fraction();
            fraction.Numerator=8;
            fraction.Denominator=28;
            Assert.AreEqual(2, fraction.Numerator);
        }

        [TestMethod()]
        public void GetDenominator_FractionCanBeShortened_ShouldReturnShortenedValue()
        {
            Fraction.Fraction fraction = new Fraction.Fraction();
            fraction.Numerator=8;
            fraction.Denominator=28;
            Assert.AreEqual(7, fraction.Denominator);
        }

        [TestMethod()]
        public void GetValue_InvalidDenominator_ShouldReturnMaxValue()
        {
            Fraction.Fraction fraction = new Fraction.Fraction();
            fraction.Numerator=3;
            Assert.AreEqual(Double.MaxValue, fraction.GetValue(), 0.01);
        }

        [TestMethod()]
        public void GetValue_FractionIsValid_ShouldReturnDoubleValue()
        {
            Fraction.Fraction fraction = new Fraction.Fraction();
            fraction.Numerator=3;
            fraction.Denominator=4;
            Assert.AreEqual(0.75, fraction.GetValue(), 0.01);
        }

        [TestMethod()]
        public void IsEqual_DifferentFractions_ShouldReturnFalse()
        {
            // Ungleiche Brüche
            Fraction.Fraction fraction = new Fraction.Fraction();
            Fraction.Fraction other = new Fraction.Fraction();
            fraction.Numerator=3;
            fraction.Denominator=4;
            other.Numerator=7;
            other.Denominator=5;
            Assert.IsFalse(fraction.IsEqual(other));
        }

        [TestMethod()]
        public void IsEqual_IsEqualAfterNormalize_ShouldReturnTrue()
        {
            // Ungleiche Brüche
            Fraction.Fraction fraction = new Fraction.Fraction();
            Fraction.Fraction other = new Fraction.Fraction();
            fraction.Numerator=3;
            fraction.Denominator=4;
            other.Numerator=6;
            other.Denominator=8;
            Assert.IsTrue(fraction.IsEqual(other));
        }

        [TestMethod()]
        public void IsEqual_InvalidFraction_ShouldReturnFalse()
        {
            // Ungleiche Brüche
            Fraction.Fraction fraction = new Fraction.Fraction();
            Fraction.Fraction other = new Fraction.Fraction();
            fraction.Numerator=3;
            fraction.Denominator=1;
            other.Numerator=6;
            other.Denominator=0;
            Assert.IsFalse(fraction.IsEqual(other));
        }


        [TestMethod()]
        public void ConvertToString_DenominatorNotInitialized_ShouldReturnErrorText()
        {
            Fraction.Fraction fraction = new Fraction.Fraction();
            fraction.Numerator=3;
            string actual = fraction.ConvertToString();
            string expected = "denominator is not initialized";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertToString_DenominatorIs0_ShouldReturnErrorText()
        {
            Fraction.Fraction fraction = new Fraction.Fraction();
            fraction.Numerator=3;
            fraction.Denominator=0;
            string actual = fraction.ConvertToString();
            string expected = "denominator is set to 0";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertToString_FractionCanBeShortened_ShouldReturnShortenedText()
        {
            Fraction.Fraction fraction = new Fraction.Fraction();
            fraction.Numerator=6;
            fraction.Denominator=8;
            string actual = fraction.ConvertToString();
            string expected = "3/4";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ConvertToString_FractionCannotBeShortened_ShouldReturnCorrectText()
        {
            Fraction.Fraction fraction = new Fraction.Fraction();
            fraction.Numerator=3;
            fraction.Denominator=4;
            string actual = fraction.ConvertToString();
            string expected = "3/4";
            Assert.AreEqual(expected, actual);
        }

    }
}
