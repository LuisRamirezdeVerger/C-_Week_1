// See https://aka.ms/new-console-template for more information
using System;

namespace Challenge
{
    public class Program
    {
        public static void Main2(string[] args)
        {

            Console.Write("Por favor, ingresa tu nombre y presiona Enter");
            string nombre = Console.ReadLine();
            Console.WriteLine(nombre.ToUpper());
            Console.WriteLine(nombre.ToLower());
            Console.WriteLine(string.IsNullOrEmpty(nombre));

        }
    }
}
/* 
Desafío: String y sus Métodos 1
Ahora que conoce el uso de varias funciones de string, creemos una pequeña aplicación de consola para practicar esto.

Declara una variable string y no le asignes ningún valor.

Imprime en la consola “Por favor, ingresa tu nombre y presiona Enter”. A continuación, puedes ingresar tu nombre o cualquier otro string válido.

Asigne ese string ingresado a la variable string que habías declarado inicialmente.

El programa debe escribir en la consola:

En la primera línea, ese string en mayúsculas

En la segunda línea el mismo string en minúsculas

En la tercera línea, escribe en la consola el string sin espacios en blanco al final o al principio, (por ejemplo si se ingresa " Federico ", debería escribirse en la consola "Federico".

Y en la última línea, debe escribir el Substring del string ingresado en la consola.

Este tipo de recursos se utilizan, por ejemplo, para crear una pantalla de inicio de sesión, para que el sistema elimine los espacios en blanco anteriores o finales, o que ignore la mayúscula del nombre de usuario ingresado.
*/