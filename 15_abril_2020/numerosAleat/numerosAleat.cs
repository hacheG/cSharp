using System;

namespace numerosAleat
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndm = new Random(); 
            int number = rndm.Next(-10, 10);
            int yourNumber, count = 0;
            
            Console.WriteLine("typeof your number");
            yourNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("let's go game");
            
            while(yourNumber != number)
            {
                count++;
                Console.WriteLine("not yet, try again");
                yourNumber = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine($"at last, the nmber was {number} and your attemps {count}");
        }
    }
}
