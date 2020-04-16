using System;

namespace metodos
{
    class Program
    {
        //campos de clase - veriables de clase
        int num1 = 1;
        int num2 = 3;
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.PrimerMetodo();
        }

        void PrimerMetodo() => Console.WriteLine( num1 + num2 );
        //expression body (=>)
    }
}
 