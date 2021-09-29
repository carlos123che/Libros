//Program 2
//Contents: source code for example 2
//Date last modified: 09/09/2021
//Version 1.0
//Author: Carlos Che
//Name: MoverRobot

using System;

namespace MoverRobot
{
    class Program
    {
        const double FACTOR_CONVERSION_GRADOS = 180 / Math.PI;
        static void Main(string[] args)
        {
            double x, y, hip, teta;

            Console.WriteLine("Este programa mueve un robot de un punto de origen a un punto especificado por usted");
            Console.WriteLine(" -Ingrese la coordenada x del punto a moverse: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine(" -Ingrese la coordenada y del punto a moverse: ");
            y = double.Parse(Console.ReadLine());

            //HIPOTENUSA
            hip = Math.Sqrt(x * x + y * y);
            //ANGULO
            teta = Math.Atan(y / x) * FACTOR_CONVERSION_GRADOS;

            //salida
            Console.WriteLine("Mueva el robot {0:f2} grados", teta);
            Console.WriteLine("y muevalo {0:f2} unidades", hip);

            Console.ReadLine();
        }
    }
}
