// See https://aka.ms/new-console-template for more information
using System;

namespace StringExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // //explicit conversion
            // double myDouble = 13.37;
            // int myInt;

            // myInt = (int)myDouble; //Give a format to "myInt"('int' in this case), but it comes from myDouble

            // //Implicit conversion
            // int num = 123456;
            // long numG = num;

            // float myFloat = 13.37f;
            // double myNewDouble = myFloat;

            // //Type conversion
            // bool elSolBrilla = true;
            // string myBoolString = elSolBrilla.ToString();
            // string myString = myDouble.ToString();
            // Console.WriteLine(myString);
            // Console.Read();

            //Bad example
            // string myString1 = "15";
            // string mySecondString = "10";

            // string resultado = myString1 + mySecondString; // Result is 1510 (is just putting together the strings)

            // int num1 = Int32.Parse(myString1); //INT32 convert a string into a 32bits number
            // int num2 = Int32.Parse(mySecondString); //Makes "myString1" an INT

            // int resultado1 = num1 + num2;
            // Console.WriteLine(resultado1);
            // Console.Read();
        }
    }

}

// namespace console //should be Uppercase("Console")
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             Console.Write("Ingresa una string y presiona Enter: ");
//             string entrada = Console.ReadLine();
//             Console.WriteLine("Has escrito: {0}", entrada); //"{0} Prints the value of whatever is after the comma("entrada" this case)

//             Console.Write("Type a key and press Enter: ");
//             int ascii = Console.Read();
//             Console.WriteLine("The ASCII value of that key is: {0}", ascii);
//             Console.ReadKey(); //The program will jump a line (stop in this case) once you press a key
//         }
//     }
// }