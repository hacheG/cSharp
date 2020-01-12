using System;

    namespace tipostring
    {
        class TheString
        {
            static void Main(string[] args)
            {
                int total, num1, num2;
                
                Console.WriteLine("tipe the first number");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("tipe the second number");
                num2 = int.Parse(Console.ReadLine());

                total = num1 + num2;
                Console.WriteLine("el resultado:" + total);
            }
        }      
    }       
