using System;

namespace Fraction
{
    /// <summary>
    /// Einfache Realisierung der rationalen Zahlen ohne spätere Themen:
    ///     Fehlerbehandlung über Exceptions
    ///     Properties
    ///     Überladen von Operatoren
    ///     Statische Methoden
    ///     Konstruktor
    /// </summary>
    public class Fraction
    {
        private int _numerator;  // Zähler
        private int _denominator; // Nenner
        private bool _isDenominatorSet;

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public Fraction()
        {
        }

        /// <summary>
        /// Property für _numerator
        /// </summary>
        public int Numerator
        {
            get
            {
                return _numerator;
            }
            set
            {
                _numerator = value;
                if (_isDenominatorSet)
                {
                    Shorten();
                }
            }
        }

        /// <summary>
        /// Property für denominaor
        /// </summary>
        public int Denominator
        {
            get
            {
                return _denominator;
            }
            set
            {
                if (value >= 0)
                {
                    _denominator = value;
                    _isDenominatorSet = true;
                    Shorten();
                }
            }
        }

        /// <summary>
        /// Ist die Bruchzahl derzeit gültig?
        /// Eine Bruchzahl ist ungültig, wenn der Nenner 0 ist.
        /// </summary>
        /// <returns></returns>
        public bool IsValid
        {
            get
            {
                if (_denominator != 0)
                {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Gekürzte Brüche stimmen bei Zähler und Nenner überein
        /// </summary>
        /// <param name="other"></param>
        /// <returns>Sind die beiden Brüche gleich?</returns>
        public bool IsEqual(Fraction other)
        {
            if (other != null)
            {
                if (_denominator == other._denominator && _numerator == other._numerator)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Wandelt den Bruch in einen String um
        /// </summary>
        /// <returns></returns>
        public string ConvertToString()
        {
            if (!_isDenominatorSet)
            {
                return "denominator is not initialized";
            }

            if (_denominator == 0)
            {
                return "denominator is set to 0";
            }
            return ($"{_numerator}/{_denominator}");
        }

        /// <summary>
        /// Liefert den Double-Wert des Bruchs
        /// </summary>
        /// <returns></returns>
        public double GetValue()
        {
            if (!IsValid)
            {
                return Double.MaxValue;
            }

            return ((double)_numerator) / _denominator;
        }

        /// <summary>
        /// Bruch so weit es geht kürzen
        /// </summary>
        private void Shorten()
        {
            if (_denominator == 0 || _numerator == 0)
            {
                return;
            }
            int divider = CalculateGgt(_numerator, _denominator);
            if (divider != 1)
            {
                _numerator /= divider;
                _denominator /= divider;
            }
        }

        /// <summary>
        /// GGT von a und b nicht rekursiv gelöst.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>ggt(a,b)</returns>
        private static int CalculateGgt(int a, int b)
        {
            int x = Math.Abs(a);
            int y = Math.Abs(b);
            // wenn a < b x und y umtauschen, sodass immer x >= y gilt
            if (x < y)
            {
                x = Math.Abs(b);
                y = Math.Abs(a);
            }
            int c = 1;  // ggt(a,b) == ggt(b, Rest(a,b)) wenn a >= b
            while (c != 0)
            {
                c = x % y;
                x = y;
                y = c;
            }
            return x;
        }

        /// <summary>
        /// Addiert zwei Bruchzahlen
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Ergebnisbruchzahl oder null im Fehlerfall</returns>
        public static Fraction Add(Fraction a, Fraction b)
        {
            if (a == null || b == null)
            {
                return null;
            }
            Fraction c = new Fraction();
            c.Numerator = (a.Numerator * b.Denominator) + (b.Numerator * a.Denominator);
            c.Denominator = a.Denominator * b.Denominator;
            if (c.Denominator == 0)
            {
                return null;
            }
            return c;
        }

        /// <summary>
        /// Subtrahiert zwei Bruchzahlen
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Fraction Sub(Fraction a, Fraction b)
        {
            if (a == null || b == null)
            {
                return null;
            }
            Fraction c = new Fraction();
            c.Numerator = (a.Numerator * b.Denominator) - (b.Numerator * a.Denominator);
            c.Denominator = a.Denominator * b.Denominator;
            if (c.Denominator == 0)
            {
                return null;
            }
            return c;
        }

        public static Fraction Mult(Fraction a, Fraction b)
        {
            if (a == null || b == null)
            {
                return null;
            }
            Fraction c = new Fraction();
            c.Numerator = a.Numerator * b.Numerator;
            c.Denominator = a.Denominator * b.Denominator;
            if (c.Denominator == 0)
            {
                return null;
            }
            return c;
        }

        public static Fraction Div(Fraction a, Fraction b)
        {
            if (a == null || b == null)
            {
                return null;
            }
            Fraction c = new Fraction();
            c.Numerator = a.Numerator * b.Denominator;
            c.Denominator = a.Denominator * b.Numerator;
            if (c.Denominator == 0)
            {
                return null;
            }
            return c;
        }
    }
}