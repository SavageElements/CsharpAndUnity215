using System;

namespace CsharpAndUnity215
{
    class Program
    {
        public class DATAInput 
        {
            public int dataInput { get; set; }

        }
        public static void Main(string[] args)
        {
            MathMethods newMethod = new MathMethods();
            
            Console.WriteLine("Step right up! Thats Right Folks! \n" +
            "Pick a number, any whole number.");

            int dataInput = Convert.ToInt16(Console.ReadLine());
            int result1 = MathMethods.DoubleUP(dataInput);
            int result2 = MathMethods.PITime(dataInput);
            int result3 = MathMethods.AddSeven(dataInput);

            Console.WriteLine("Your number doubled is " + result1);
            Console.WriteLine("Your number times 3 is " + result2);
            Console.WriteLine("Your number plus Seven is " + result3);

        }
    }
}
