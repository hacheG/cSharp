using System;

namespace primeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 19;
            var unaVariableConTipeAutomatico = "no se puede cambiar su tipo despues";
            float conEfe = 2.3f;
            double temp = 3.5;
            int newTemp;

            newTemp = (int) temp;
              
            Console.WriteLine(5.0/5);
            Console.WriteLine( unaVariableConTipeAutomatico);
            Console.WriteLine(temp);
            Console.Write(newTemp);
            Console.Write("\n");
            Console.Write(conEfe); 
        }
    }
}