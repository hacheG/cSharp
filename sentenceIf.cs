using System;

namespace Condicional
{
    class SentenceIf
    {
        static void Main(string[] args)
        {
            bool haceFrio = true;
            Console.WriteLine(!haceFrio);

            int age = 15;

            Console.WriteLine("vamos a evaluar si eres mayor de edad");
            if (age >= 18)
            {
                Console.WriteLine("eres mayor de edad");
            }
            else
            {
                Console.WriteLine("no eres mayor de edad");
            }
        }
    }
}