using System;

namespace ambitSobrec
{
    class Name
    {
        static void Main(string[] args)
        {
            int valor1 = 7;
            double valor2 = 5.2;
            double valor3 = 8.3;

            Console.WriteLine(suma(valor1,valor3, valor2));
        }
        //para hacer sobrecarga, losmetodos deben tener o diferente numero de parametros o diferentes tipos
        //dos parametros obligatorios y uno opcional, es com tener una sobre carga pero sin escribir la sobre carga, 
        //asi no molesta en la integracion con otros lenguajes
        //LOS PARAMETROS OPCIONALES DEBEN IR SIEMPRE AL FINAL
        static double suma(int op1, double op2, double op3=0)
        {
            return op1 + op2 + op3;
        }
        
    }
}