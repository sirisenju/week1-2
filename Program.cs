using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args){

            // Lab 1 assignment!
            String? name = "Emuesiri";
            String? track = "Backend";

            Console.WriteLine("Hello "+ name);
            Console.WriteLine("I am in "+ track + " of Wella Schools");
            Console.WriteLine("Well, I find backend more facinatig. The shadow that ensure the light survives.");

            // Lab 2 assignment!
            int num1 = 385874885;
            double num2 = 45.77;
            long num3 = 84775886997978L;
            float num4 = 8.953f;
            byte num5 = 45;
            char text1 = '@';
            String text2 = "Siri";
            decimal num6 = 1000.1m;
            bool value = true;
            short num7 = 32000;

            /* Implicit casting automatically converts a smaller type to a larger type size of diffrent 
            data type*/
            int myInt = 78;
            double myDouble = myInt;
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            /* Explicit casting must be done manually by placing the type in the parentheses in front of 
            the value*/
            double myDouble2 = 8.99;
            int myInt2 = (int) myDouble2;
            Console.WriteLine(myInt2);
            Console.WriteLine(myDouble2);
        }
    }
}