using System;

class PadRight
{
   public static void Main()
   {
   string str = "muy buenos dias";
   char uno = '.';

   Console.WriteLine(str.PadRight(20, uno));
   Console.WriteLine(str.PadRight(4, uno));
   }
}