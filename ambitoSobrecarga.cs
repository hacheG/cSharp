using System;

namespace ambitSobrec
{
    class Name
    {
        static void Main(string[] args)
        {
            Console.WriteLine(suma(7, 5.5));
        }
        //para hacer sobrecarga, losmetodos deben tener o diferente numero de parametros o diferentes tipos
        static int suma(int op1, int op2)
        {
            return op1 + op2;
        }
        static double suma(int op1, double op2)
        {
            return op1 + op2;
        }
        static int suma(int val1, int val2, int val3)
        {
            return val1 + val2;
        }
    }
}