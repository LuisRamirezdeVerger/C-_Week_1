// See https://aka.ms/new-console-template for more information
using System;

namespace HolaMundo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;

            int num3, num4, num5; //Even the don't have value, var are declared so we can use'em later

            double d1 = 3.2;
            double d2 = 1.337;
            double sumd = d1 + num2;

            float f1 = 3.5f; //All float values MUST have an "f" at the end!!
            Console.WriteLine("La suma de " + d1 + " más " + num2 + " da como resultado " + sumd); //console.log in JS
            Console.Read(); // to keep the terminal open so we can see the result
        }
    }
}
