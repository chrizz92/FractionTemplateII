using System;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number;

            Fraction.Fraction b1 = new Fraction.Fraction();
            Fraction.Fraction b2 = new Fraction.Fraction();
            Console.Write("Bitte ersten Nenner eingeben: ");
            b1.Numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte ersten Zähler eingeben: ");
            b1.Denominator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte zweiten Nenner eingeben: ");
            b2.Numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte zweiten Zähler eingeben: ");
            b2.Denominator = Convert.ToInt32(Console.ReadLine());
            /*ALTERNATIVE 1
            Fraction.Fraction b3;
            b3 = Fraction.Fraction.Add(b1, b2);
            Console.WriteLine(b3.ConvertToString());
            b3 = Fraction.Fraction.Sub(b1, b2);
            Console.WriteLine(b3.ConvertToString());
            ...
            ...
            */
            /*ALTERNATIVE 2
            Fraction.Fraction b3 = Fraction.Fraction.Add(b1, b2);
            Console.WriteLine(b3.ConvertToString());
            b3 = Fraction.Fraction.Sub(b1, b2);
            Console.WriteLine(b3.ConvertToString());
            ...
            ...
            */
            Console.WriteLine("=====================================");
            Console.WriteLine(Fraction.Fraction.Add(b1, b2).ConvertToString());
            Console.WriteLine(Fraction.Fraction.Sub(b1, b2).ConvertToString());
            Console.WriteLine(Fraction.Fraction.Mult(b1, b2).ConvertToString());
            Console.WriteLine(Fraction.Fraction.Div(b1, b2).ConvertToString());
        }
    }
}