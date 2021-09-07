//Program 1
//Contents: source code for example 1
//Date last modified: 07/09/2021
//Version 1.0
//Author: Carlos Che
//Name: Program1

using System;

namespace Program1
{

    class Program
    {
        const int VERSION = 1; //global
        static void Main(string[] args)
        {
            //DECLARE AND INITIALIZE STRINGS
            String name = "Carlos Ché";
            String course = "CS1400 Section 001";
            String version = "Version " + VERSION;
            String project = "Program One";
            String date = "September 07 of 2021";

            //DISPLAY THE STRINGS
            Console.WriteLine(name);
            Console.WriteLine(course);
            Console.WriteLine(version);
            Console.WriteLine(project);
            Console.WriteLine(date);
        }
    }
}
