using System;
using System.Collections;

namespace split

{
    class split
    {
        static void Main(string[] args)
        {
            string palabra = "el unico-modo+de/hacer/un$trabajo";

            string[] array = palabra.Split(' ', '-', '+', '/', '$');

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}