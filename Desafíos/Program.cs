// See https://aka.ms/new-console-template for more information
using System;

namespace Challenge2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Por favor, ingresa tu nombre y presiona Enter");
            string nombre = Console.ReadLine();

            Console.WriteLine(nombre.ToUpper());
            Console.WriteLine(nombre.ToLower());
            Console.WriteLine(nombre.Trim()); //Trim eliminates any white space atb and at the end of the string
            Console.WriteLine("Has escrito: {0}", nombre);
            Console.WriteLine(nombre.Substring(0, 5));
            Console.Read();

        }
    }
}
/* 
using System;

namespace Challenge
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Por favor, ingresa tu nombre y presiona Enter");
            string nombre = Console.ReadLine();

            Console.WriteLine(nombre.ToUpper());
            Console.WriteLine(nombre.ToLower());
            Console.WriteLine(nombre.Trim()); //Trim eliminates any white space atb and at the end of the string
            Console.WriteLine("Has escrito: {0}", nombre);
            Console.WriteLine(nombre.Substring(0, 5));
            Console.Read();

        }
    }
}
*/