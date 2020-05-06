using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            double redondear = 8.55;
            int cuatro = 4;

            // Raiz cuadrada
            Console.WriteLine("Escribe un numero para sacar la raiz cuadrada");
            int numeroRaiz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Raiz cuadrada: {System.Math.Sqrt(numeroRaiz)}");

            // //4ta potencia 
            Console.WriteLine("Escribe un numero para elevarlo a la 4ta potencia");
            int numero4ta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Resultado: {System.Math.Pow(numero4ta, cuatro)}");

            //Signo de un numero
            Console.WriteLine("Escribe un numero para sacar el signo");
            int signoNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Resultado: {System.Math.Sign(signoNumero)}");

            //Numero mas grande
            Console.WriteLine("Escribe un numero para ver cual es mas grande");
            int numeroUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe otro numero para ver cual es mas grande");
            int numeroDos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Numero mas grande: {System.Math.Max(numeroUno, numeroDos)}");

            //Numero mas grande sin importar el simbolo 
            Console.WriteLine("Escribe un numero para ver cual es mas grande sin importar el simbolo ");
            int numeroUnoSimbolo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe otro numero para ver cual es mas grande sin importar el simbolo ");
            int numeroDosSimbolo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Numero mas grande: {System.Math.Max(System.Math.Abs(numeroUnoSimbolo), System.Math.Abs(numeroDosSimbolo))}");

            //Quitar los decimales a un numero
            Console.WriteLine("Escribe un numero con decimales, para quitárselos");
            decimal numeroDecimal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Numero sin decimales: {System.Math.Truncate(numeroDecimal)}");

            // Redondear 8.55
            Console.WriteLine($"8.55 redondeado: {System.Math.Round(redondear)}");
        }
    }
}
