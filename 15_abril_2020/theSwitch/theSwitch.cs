using System;

namespace theSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string transp;

            Console.WriteLine("tell me youy transportation");
            transp = Console.ReadLine();

            switch(transp)
            {
                case "car":
                    Console.WriteLine("enjoy your car");
                    break;
                case "bus":
                    Console.WriteLine("a bus is better");
                    break;
                default:
                    Console.WriteLine("ok notting");
                    break;
            }
        }
    }
}
