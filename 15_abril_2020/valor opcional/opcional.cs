using System;

namespace valor_opcional
{
    class Program
    {
        int num1 = 7;
        double num2 = 5.2;  
        double num3 = 8.3;
        static void Main(string[] args)
        {
            Console.WriteLine(Suma(num1, num2));
        }

        static double Suma(int num1, double num2, double num3=0) => num1+num2+num3;
        //dandole el valor en cero se vuelve OPCIONAL
        static double Suma(int num1, double num2) => num1+num2;
        //en este caso, por la sobrecarga, el programa ejecuta la funcion que mas
        //se adapte a los valores que se le pasaron 
    }
}
