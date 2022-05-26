using System;
using System.Text;
namespace ToString
{
    class ToString
{

    public static void Main(String[] args)
    {

        StringBuilder abc
          = new StringBuilder(" 15,30,45,60,75 ");


        Console.WriteLine(" El string contiene los siguientes datos: "
                            + abc.ToString());
        Console.WriteLine(" Estos datos son verdaderos "); 
    }
}
}
