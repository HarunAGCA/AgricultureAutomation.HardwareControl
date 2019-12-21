using AgricultureAutomation.HardwareControl.Control.Abstract;
using AgricultureAutomation.HardwareControl.Control.Concrete;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ILedController ledController = new LedController();

            while (true)
            {
                string a = Console.ReadLine();
                Console.WriteLine(a);
                if(a == "open")
                {
                    ledController.Open();
                    Console.WriteLine("opened");
                }
                else if(a=="close")
                {
                    ledController.Close();
                    Console.WriteLine("closed");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

        }
    }
}
