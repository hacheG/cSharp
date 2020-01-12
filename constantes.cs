using System;

namespace managmentCostants
{
    class contantes
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;
            const int VALUE2 = 7;
            double area, radio;

            Console.WriteLine("la constante es: {0} {1}", PI, VALUE2);
            Console.WriteLine("la constante es:" + PI + VALUE2);
            Console.WriteLine("type the radium of circle");
            
            radio = double.Parse(Console.ReadLine());
            //area = radio * radio *PI;
            area = (Math.Pow(radio, 2)) * PI;
            Console.WriteLine("el area es: {0}", area);
        }
    }
}