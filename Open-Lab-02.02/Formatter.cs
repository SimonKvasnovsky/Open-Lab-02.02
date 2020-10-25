using NUnit.Common;
using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write(Math.Round(numbers[i], 2).ToString(System.Globalization.CultureInfo.InvariantCulture.NumberFormat));
                Console.Write(" ");
            }
            Console.Write(Math.Round(numbers[numbers.Length-1], 2).ToString(System.Globalization.CultureInfo.InvariantCulture.NumberFormat));
        }
       
}   }
