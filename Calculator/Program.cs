using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class FractionalNumber
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public FractionalNumber(int numeratorValue, int denominatorValue)
        {
            if (denominatorValue == 0)
            {
                throw new Exception("Знаминатель не должен быть равен 0");
            }

            this.Numerator = numeratorValue;
            this.Denominator = denominatorValue;
        }

        public static FractionalNumber SumFractionalNumbers(FractionalNumber fractionalNumber1, FractionalNumber fractionalNumber2)
        {
            if (fractionalNumber1.Denominator == fractionalNumber2.Denominator)
            {
                int numerator = fractionalNumber1.Numerator + fractionalNumber2.Numerator;
                int denominator = fractionalNumber2.Denominator;

                return new FractionalNumber(numerator, denominator);
            } 
            else
            {
                int numerator = fractionalNumber1.Numerator * fractionalNumber2.Denominator + fractionalNumber2.Numerator * fractionalNumber1.Denominator;
                int denominator = fractionalNumber1.Denominator * fractionalNumber2.Denominator;

                return new FractionalNumber(numerator, denominator);
            }
        }

        public static FractionalNumber SubtractFractionalNumbers(FractionalNumber fractionalNumber1, FractionalNumber fractionalNumber2)
        {
            if (fractionalNumber1.Denominator == fractionalNumber2.Denominator)
            {
                int numerator = fractionalNumber1.Numerator - fractionalNumber2.Numerator;
                int denominator = fractionalNumber2.Denominator;

                return new FractionalNumber(numerator, denominator);
            }
            else
            {
                int numerator = fractionalNumber1.Numerator * fractionalNumber2.Denominator - fractionalNumber2.Numerator * fractionalNumber1.Denominator;
                int denominator = fractionalNumber1.Denominator * fractionalNumber2.Denominator;

                return new FractionalNumber(numerator, denominator);
            }
        }

        public static FractionalNumber MultiplyFractionalNumbers(FractionalNumber fractionalNumber1, FractionalNumber fractionalNumber2)
        {
            int numerator = fractionalNumber1.Numerator * fractionalNumber2.Numerator;
            int denominator = fractionalNumber1.Denominator * fractionalNumber2.Denominator;

            return new FractionalNumber(numerator, denominator);
        }

        public static FractionalNumber DivideFractionalNumbers(FractionalNumber fractionalNumber1, FractionalNumber fractionalNumber2)
        {
            FractionalNumber invertedАraction = new FractionalNumber(fractionalNumber2.Denominator, fractionalNumber2.Numerator);

            return FractionalNumber.MultiplyFractionalNumbers(fractionalNumber1, invertedАraction);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FractionalNumber fractionalNumber1 = new FractionalNumber(1, 2);
                FractionalNumber fractionalNumber2 = new FractionalNumber(3, 4);

                //FractionalNumber fractionalNumber3 = FractionalNumber.SumFractionalNumbers(fractionalNumber1, fractionalNumber2);
                //Console.WriteLine("Sum Fractional Numbers");
                //Console.WriteLine("Numerator: {0}\nDenominator: {1}", fractionalNumber3.Numerator, fractionalNumber3.Denominator);

                //FractionalNumber fractionalNumber4 = FractionalNumber.SubtractFractionalNumbers(fractionalNumber1, fractionalNumber2);
                //Console.WriteLine("Subtract Fractional Numbers");
                //Console.WriteLine("Numerator: {0}\nDenominator: {1}", fractionalNumber4.Numerator, fractionalNumber4.Denominator);

                //FractionalNumber fractionalNumber5 = FractionalNumber.MultiplyFractionalNumbers(fractionalNumber1, fractionalNumber2);
                //Console.WriteLine("Multiply Fractional Numbers");
                //Console.WriteLine("Numerator: {0}\nDenominator: {1}", fractionalNumber5.Numerator, fractionalNumber5.Denominator);

                FractionalNumber fractionalNumber6 = FractionalNumber.DivideFractionalNumbers(fractionalNumber1, fractionalNumber2);
                Console.WriteLine("Divide Fractional Numbers");
                Console.WriteLine("Numerator: {0}\nDenominator: {1}", fractionalNumber6.Numerator, fractionalNumber6.Denominator);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
