using System;

namespace sobregarga_de_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma(1, 2.2); 
        }

        static int Suma(int operador1, int operador2) => operador1+operador2;

        static double Suma(int operador1, double operador2) => operador1+operador2;
        
        static int Suma(int operador1, int operador2, int operador3) => operador1+operador2;

        static int Suma(int operador1, int operador2, int operador3, int operador4) => operador1+operador2;
    }
}
