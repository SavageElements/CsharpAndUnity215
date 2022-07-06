using System;

namespace CsharpAndUnity215
{
    class Program
    {
        public class DATAInput 
        {
            public double dataInput { get; set; }

        }
        public static void Main(string[] args)
        {
            MathMethods newMethod = new MathMethods();
            
            Console.WriteLine("Step right up! Thats Right Folks! \n" +
            "Pick a number, any whole number.");

            double dataInput = Convert.ToDouble(Console.ReadLine());
            double result1 = MathMethods.DoubleUP(dataInput);
            double result2 = MathMethods.PITime(dataInput);
            double result3 = MathMethods.AddSeven(dataInput);

            Console.WriteLine("Your number doubled is " + result1);
            Console.WriteLine("Your number times PI is " + result2);
            Console.WriteLine("Your number plus Seven is " + result3);

        }
    }
}
