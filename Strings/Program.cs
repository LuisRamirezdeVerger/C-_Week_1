// See https://aka.ms/new-console-template for more information
using System;

namespace StringExample
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string MiNombre = "Wito";
            string mensaje = "Mi nombre es " + MiNombre;
            string MensMay = mensaje.ToUpper(); // The string will be in upper case
            string MensMin = mensaje.ToLower();

            //To color it...
            Console.ForegroundColor = ConsoleColor.DarkGreen; //This is a property
            Console.BackgroundColor = ConsoleColor.Yellow;    //This is a property
            Console.Clear(); //We clear the buffer(past orders) to take new ones, so we can print the whole screen on yellow

            Console.WriteLine(MensMay);
            Console.WriteLine(MensMin);
            Console.Read();
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