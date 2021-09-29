//Program 1
//CS 1400 Sectio 002
//Instructor: Prof debr
//Contents: source code for exercise2
//Date last modified: 09/29/2021
//Version 1.0
//Author: Carlos Che
using System;

namespace C2_E2_Lineas_Telefónicas
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variables
            int n;
            double lines;
            // prompt the user for info
            Console.WriteLine("****Se calculará el número de líneas necesario para conectar n teléfonos****");
            Console.Write("Ingrese el valor de n: ");
            //get input
            n = Convert.ToInt32(Console.ReadLine());
            //calculate the answer
            lines = n * (n - 1) / 2;
            //ouput the answer
            Console.Write("El número de lineas necesario para conectar ");
            Console.Write(n.ToString());
            Console.Write(" telefonos es: ");
            Console.Write(lines.ToString());
            Console.ReadLine();
        }
    }
}
