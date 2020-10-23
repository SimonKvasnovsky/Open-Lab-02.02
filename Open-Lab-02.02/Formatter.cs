using NUnit.Common;
using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)

        {
            for (int i = 0; i < numbers.Length - 1; i++)
            Console.Write(numbers[i].ToString(System.Globalization.CultureInfo.InvariantCulture.NumberFormat));
            String.Format("{0:0.00}", numbers);
            Console.Write(" ");
            {
                Console.Write(numbers[numbers.Length - 1].ToString(System.Globalization.CultureInfo.InvariantCulture.NumberFormat));
            }

        }
       
}   }
