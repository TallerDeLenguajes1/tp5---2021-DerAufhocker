using System;

namespace Tp5_DiazExequiel
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int op;
             InvertirNumero();
             do
             {
                 Calculadora();
                 Console.WriteLine("¿Quiere realizar otra operacion? 1.Si 2.No");
                 op = int.Parse(Console.ReadLine());
             } while (op == 1);*/
            palabras();
        }

        /*******PUNTO 1*********/
        static void InvertirNumero()
        {
            int num, resto, invertido = 0;
            Console.WriteLine("Ingrese un numero:");
            num = int.Parse(Console.ReadLine());

            if (num > 0)//123
            {
                while (num != 0)
                {
                    resto = num % 10;//2
                    num = num / 10;
                    invertido = invertido * 10 + resto;//3+2
                }
            }
            else
            {
                Console.WriteLine("No se puede convertir");
            }
            Console.WriteLine("El numero invertido es: " + invertido);
        }
        /********PUNTO 2*******/
        static void Calculadora()
        {
            int operacion, num1, num2;
            Console.WriteLine("¿Que operacion quiere realizar?");
            Console.WriteLine("1. Suma      2. Resta        3. Producto     4.Cociente");
            operacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese dos numeros:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            switch (operacion)
            {
                case 1:
                    Console.WriteLine($"El valor de la suma entre {num1} y {num2} es: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"El valor de la resta entre {num1} y {num2} es: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"El valor del producto entre {num1} y {num2} es: {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine($"El valor del cociente entre {num1} y {num2} es: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("no se puede dividir entre cero");
                    }
                    break;
                default:
                    Console.WriteLine("ingreso incorrecto");
                    break;
            }
        }
        /********PUNTO 3********/
        static void Calculadora2()
        {
            double num1, num2;
            Console.WriteLine("Ingrese dos numeros:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"El valor absoluto de {num1} es {Math.Abs(num1)}");
            Console.WriteLine($"El cuadrado de {num1} es {Math.Pow(num1, 2)}");
            Console.WriteLine($"La raiz cuadrada de {num1} es {Math.Sqrt(num1)}");
            Console.WriteLine($"EL seno de {num2} es {Math.Sin(num2)}");
            Console.WriteLine($"El coseno de {num2} es {Math.Cos(num2)}");
            Console.WriteLine($"La prte entera de {num1} es {(int)num1}");
            Console.WriteLine($"El maximo es {Math.Max(num1, num2)}");
            Console.WriteLine($"El minimo es {Math.Min(num2, num1)}");
        }
        /********PUNTO 4*********/

        static void palabras()
        {
            string oracion1,oracion2;
            int largo;


            Console.WriteLine("Ingrese un oracion:\n");
            oracion1 = Console.ReadLine();
            Console.WriteLine("retiraremos la letra \"a\" de la cadena");
            oracion2 = oracion1.Replace("a", string.Empty);
            Console.WriteLine($"La oracion modificada quedaria:\n\t {oracion2}");
            largo = oracion1.Length;
            Console.WriteLine($"El largo de la cadena ingresada es {oracion1.Length}");
            //Separo una cadena en trozos
            string frase = "Bienvenidos a la clase de C#. C# es un lenguaje fuertemente tipado";
            Console.WriteLine("\n\n");
            //si quiero obtener una subfrase necesito separarla a traves de un delimitador
            //Obtengo la oracion desde el inicio hasta donde encuentre un punto
            Console.WriteLine(frase.Substring(0, frase.IndexOf('.')));//el cero indica la posicion del string y el '.' es el delimitador
            Console.WriteLine("\n\n");
            Console.WriteLine(frase.Substring(frase.IndexOf('.')+1));//obtengo la frase que esta desues del delimitadr más un lugar
        
            foreach(char letra in oracion1)
            {
                Console.WriteLine(letra);
            }

            //obtener una fraccion de una horacion
            string control = "lenguaje";
            bool a = frase.Contains(control);
            if (a)
            {
                Console.WriteLine($"La palabra '{control}' si se encuentra en '{frase}'");
            }
            else
            {
                Console.WriteLine("no se encuentra la palabra");
            }

        }
    
    }
}
