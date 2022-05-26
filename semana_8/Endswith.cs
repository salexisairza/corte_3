using System;
using System.Collections; 

namespace EndsWith
{
    class EndsWith
    {
        static void Main(string[] args)
        {
            
            string palabra = "si se puede IMAGINAR, se puede Programar";
           
            Console.WriteLine(palabra);
            Console.WriteLine(palabra.EndsWith("IMAGINAR"));
            Console.WriteLine(palabra.EndsWith(" Programar"));
        }
    }
}