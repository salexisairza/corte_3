sing System;
using System.Collections;

namespace Remove
{
    class program
    {
        static void Main(string[] args)
        {
            String cadenainicial = "el unico mode de hacer un gran trabajo es amar lo que haces ";

            Console.WriteLine("Cadena original: " + cadenainicial);

            Console.WriteLine("");

            Console.WriteLine("Cadena 1 alterada: " + cadenainicial.Remove(6, 7));

            Console.WriteLine("");

            Console.WriteLine("Cadena 2 alterada: " + cadenainicial.Remove(2, 8));

            Console.WriteLine("");

            Console.WriteLine("Cadena 3 alterada: " + cadenainicial.Remove(20, 4));

            Console.WriteLine("");

            Console.WriteLine("Cadena 4 alterada: " + cadenainicial.Remove (24, 5));

            Console.WriteLine("");

            Console.WriteLine("Cadena 5 alterada: " + cadenainicial.Remove(3, 24));

            Console.WriteLine("");

            Console.WriteLine("Cadena 6 alterada: " + cadenainicial.Remove(15, 10));

            Console.WriteLine("");



        }
    }
    
}