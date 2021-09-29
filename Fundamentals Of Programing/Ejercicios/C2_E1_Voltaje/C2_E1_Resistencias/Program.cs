//Program 1
//CS 1400 Sectio 002
//Instructor: Prof debr
//Contents: source code for exercise 1
//Date last modified: 09/29/2021
//Version 1.0
//Author: Carlos Che
using System;

namespace C2_E1_Resistencias
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare local variables
            double i, res1, res2, Req, v;

            //prompt the user for input
            Console.WriteLine("****Se calculara el voltaje que pasa por las 2 resistencias****");
            //pedir i
            Console.WriteLine("-Ingrese el valor de i: ");
            i = Convert.ToDouble(Console.ReadLine());
            // pedir res1
            Console.WriteLine("-Ingrese el valor de la resistencia 1: ");
            res1 = Convert.ToDouble(Console.ReadLine());
            // pedir res2
            Console.WriteLine("-Ingrese el valor de la resistencia 2: ");
            res2 = Convert.ToDouble(Console.ReadLine());

            //calcular la respuesta
            Req = res1 + res2;
            v = i * Req;

            //output the answer
            Console.Write("El voltaje que pasa por las dos resistencias es: ");
            Console.Write(v.ToString());
            Console.ReadLine();
        }
    }
}
