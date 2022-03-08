// See https://aka.ms/new-console-template for more information
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //operators
            num3 = -num1;
            Console.WriteLine("El valor negativo de num1 es {0}", num3);

            bool haySol = true;
            Console.WriteLine("¿Hay sol? {0}", !haySol); // "!" -> the opposite


            //operadores de adición

            int num = 0;
            num++;
            Console.WriteLine("num es {0}", num);
            Console.WriteLine("num es {0}", num++); //Se aplica en la siguiente linea
            Console.WriteLine("num es {0}", num);
            Console.Read();

            // operadores de sustracción

            num--;
            Console.WriteLine("num es {0}", num);
            Console.WriteLine("num es {0}", --num); //Se aplica en ésta línea
            Console.WriteLine("num es {0}", num);
            Console.Read();

            // operadores matemáticos

            int resultado = num1 + num2;
            Console.WriteLine("El resultado de " + num1 + " + " + num2 + " es igual a " + resultado);

            resultado = num1 - num2;
            Console.WriteLine("El resultado de " + num1 + " - " + num2 + " es igual a " + resultado);

            resultado = num1 * num2;
            Console.WriteLine("El resultado de " + num1 + " * " + num2 + " es igual a " + resultado);

            resultado = num1 / num2;
            Console.WriteLine("El resultado de " + num1 + " / " + num2 + " es igual a " + resultado);

            //Operador modular (divide 2 numeros y te MUESTRA el "resto")  
            resultado = num1 % num2;
            Console.WriteLine("El resultado de " + num1 + " % " + num2 + " es igual a " + resultado);
            // "5 / 3 = 1", pero al ser MODULAR, el resultado en pantalla es el resto, por lo tanto, el resultado en pantalla es "2"

            //operadores relacionales
            bool esMenor;
            esMenor = num1 < num2;
            Console.WriteLine("El resultado de " + num1 + " < " + num2 + " es igual a " + esMenor);
            //false


            //operadores de igualdad
            bool esIgual;
            esIgual = num1 == num2;
            Console.WriteLine("El resultado de " + num1 + " == " + num2 + " es igual a " + esIgual);
            //false

            esIgual = num1 != num2;
            Console.WriteLine("El resultado de " + num1 + " != " + num2 + " es igual a " + esIgual);
            //true

            //operadores condicionales
            //Y
            bool esMenorYSoleado;

            esMenorYSoleado = esMenor && haySol;
            Console.WriteLine("El resultado de " + esMenor + " && " + haySol + " es igual a " + esMenorYSoleado);
            //false

            esMenorYSoleado = esMenor || haySol;
            Console.WriteLine("El resultado de " + esMenor + " || " + haySol + " es igual a " + esMenorYSoleado);
            //O
        }


    }


}

/* 

static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingresa un número");
            string valorIngresado = Console.ReadLine();

            int num1 = 5;
            int num2 = 0;
            int resultado;

            resultado = num1 / num2;


            try
            {
                int valorComoInt = int.Parse(valorIngresado);
            }
            catch (FormatException) //If we write "exception" it'll take ALL kind of errors
            {
                Console.WriteLine("El formato del valor ingresado es incorrecto");
            }
            catch (DivideByZeroException) //If we write "exception" it'll take ALL kind of errors
            {
                Console.WriteLine("No se puede dividir entre 0");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El número ingresado es demasiado largo o corto");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No se ha ingresado ningún valor");
            }
            finally //if we have errors or not, "finally" do  whatever
            {
                Console.WriteLine("Esta frase aparece pase lo que pase");
            }
            Console.Read();
        }


 - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - - 
 - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  


 static void Main(string[] args)
        {
            // string input = Console.ReadLine(); //Value of "input" depends on what the user type in
            Console.WriteLine(Calcular());
            Console.Read();
        }
        public static int Calcular()
        {
            Console.WriteLine("Por favor, ingresa un número");
            string num1Input = Console.ReadLine();
            Console.WriteLine("Por favor, ingresa otro número");
            string num2Input = Console.ReadLine();

            int num1 = int.Parse(num1Input);
            int num2 = int.Parse(num2Input);



            int resultado = num1 + num2;
            return resultado; //So, is not void. We need RETURN
        }

 - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - - 
 - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  

static void Main(string[] args)
        {
            string amigo1 = "Pablo";
            string amigo2 = "Daniel";
            string amigo3 = "Lucas";
            SaludarAmigo(amigo1, amigo2, amigo3);
            // SaludarAmigo(amigo1);
            // SaludarAmigo(amigo2);
            // SaludarAmigo(amigo3);
            Console.Read();
        }

        public static void SaludarAmigo(string nombreAmigo1, string nombreAmigo2, string nombreAmigo3)
        {
            Console.WriteLine("Hola " + nombreAmigo1 + ", yeeee");
            Console.WriteLine("Hola " + nombreAmigo2 + ", yeeee");
            Console.WriteLine("Hola " + nombreAmigo3 + ", yeeee");
            //Console.WriteLine("Hola " + nombreAmigo + ", yeeee");
        }
    }

 - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - - 
 - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  


        public static void Main(string[] args)
        {
            // int resultado = Sumar(15, 31);
            Console.WriteLine(Sumar(15, 31)); //We can call "Resultado" here as well
            Console.WriteLine(Multiplicar(7, 8));
            Console.WriteLine(Dividir(25, 13));
            Console.Read();
        }

        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Dividir(double num1, double num2)
        {
            return num1 / num2;
        }

 - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - - 
 - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - -  - - - - - - - - - - 

// See https://aka.ms/new-console-template for more information
using System;

namespace Challenge2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EscribeAlgo();
            EscribeAlgoEspecifico("Soy un argumento y me llamaron desde un método");
            Console.Read();
        }
        //public can be called from anywhere. 
        //Void, 'cause we don't spect any return
        // NivelDeAcceso - (static) - TipoDeRetorno - NombreDeMétodo (Parámetro1, Parámetro2)
        public static void EscribeAlgo() //Static is a declaration de que este metodo no pertenece a un objeto 
        {
            Console.WriteLine("Yo nací en un método");
            // Console.Read();
        }

        public static void EscribeAlgoEspecifico(string miTexto)
        {
            Console.WriteLine(miTexto);
            // Console.Read();
        }
    }

}
*/