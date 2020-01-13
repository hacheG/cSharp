using System;

namespace makeMethod
{
    class neMetod
    {
        static void Main(string[] args)
        {
            mensajeEnPantalla();
            Console.Write(sumaNumeros(2, 4));
            
        }
        static void mensajeEnPantalla()
        {
            Console.WriteLine("holi Koa");
        }

        static int sumaNumeros(int num1, int num2)
        {
            return num1 + num2;
        }
        //con una flecha tambien funciona para una sola linea de codigo
        //static int sumaNumeros(int num1, int num2) => num1 + num2;
    }
}