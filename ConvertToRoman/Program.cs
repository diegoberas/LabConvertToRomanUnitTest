using System;

namespace ConvertToRoman
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double number;
                Console.Write("Introduce a value between 1 and 3999: ");
                number = double.Parse(Console.ReadLine());
                number = Math.Round(number);
                Console.WriteLine(ToRoman(number));
            }
            catch (Exception)
            {
                //Empty
                Console.WriteLine("Must introduce a integer value between 1 and 3999");
               
            }
            

            Console.ReadKey();

        }

        public static string ToRoman(double number)
        {
            if ((number < 0) || (number > 3999)) //Negative Numbers and over 3999 numbers
            {
                return "Value out of range";
            }
            else if (number >= 1000)
            {
                return "M" + ToRoman(number - 1000);
            }
            else if (number >= 900)
            {
                return "CM" + ToRoman(number - 900);
            }
            else if (number >= 500)
            {
                return "D" + ToRoman(number - 500);
            }
            else if (number >= 400)
            {
                return "CD" + ToRoman(number - 400);
            }
            else if (number >= 100)
            {
                return "C" + ToRoman(number - 100);
            }
            else if (number >= 90)
            {
                return "XC" + ToRoman(number - 90);
            }
            else if (number >= 50)
            {
                return "L" + ToRoman(number - 50);
            }
            else if (number >= 40)
            {
                return "XL" + ToRoman(number - 40);
            }
            else if (number >= 10)
            {
                return "X" + ToRoman(number - 10);
            }
            else if (number >= 9)
            {
                return "IX" + ToRoman(number - 9);
            }
            else if (number >= 5)
            {
                return "V" + ToRoman(number - 5);
            }
            else if (number >= 4)
            {
                return "IV" + ToRoman(number - 4);
            }
            else if (number >= 1)
            {
                return "I" + ToRoman(number - 1);
            }
           
            
            return string.Empty;
        }

        //Test empty string
        public static string ToRoman()
        {
            return "Must introduce a integer value between 1 and 3999";

        }
    }
}
