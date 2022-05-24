using System;
  
namespace lastlndexof
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string palabras  = "La tarea de un hacker no es destruir, sino utilizar sus conocimientos en favor de la libertad y la igualdad social  ";
           
            Console.WriteLine(palabras);
            int palabra = palabras.LastIndexOf("hacker");
            Console.WriteLine("lo encontre esta en la posicion: "+palabra);
        
        }
    }
}