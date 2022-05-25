using System;

namespace trimEnd
{
    class TrimEnd
    {
        static void Main(string[] args)
        {
            char[] chars = { ' ', '#', '-' };
            string palabra1 = "  Hola   ";
            string palabra2 = "##Como##   ";
            string palabra3 = "Estas--";

            Console.WriteLine("Antes");
            Console.WriteLine(palabra1);
            Console.WriteLine(palabra2);
            Console.WriteLine(palabra3);

            Console.WriteLine("despues");
            Console.WriteLine(palabra1.TrimEnd(chars));
            Console.WriteLine(palabra2.TrimEnd(chars));
            Console.WriteLine(palabra3.TrimEnd(chars));

        }
    }