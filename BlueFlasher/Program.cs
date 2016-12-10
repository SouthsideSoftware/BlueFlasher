using DelcomSupport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlueFlasher
{
    class Program
    {
        static void Main(string[] args)
        {
            while (1 == 1)
            {
                Console.WriteLine("Press <space> to flash blue.  Any other key to exit");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Spacebar)
                {
                    Console.WriteLine("Flashing...");
                    Flash();
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }
        }

        static void Flash() { 
            DelcomLight light = new DelcomLight();
            try
            {
                //Here are all the possibilities with the three-color Delcom

                //light.ChangeIndicator(DelcomIndicatorState.SolidGreen);
                //light.ChangeIndicator(DelcomIndicatorState.FlashingGreen);
                //light.ChangeIndicator(DelcomIndicatorState.Off);
                //light.ChangeIndicator(DelcomIndicatorState.SolidRed);
                //light.ChangeIndicator(DelcomIndicatorState.FlashingRed);
                //light.ChangeIndicator(DelcomIndicatorState.Off);
                //light.ChangeIndicator(DelcomIndicatorState.SolidBlue);
                light.ChangeIndicator(DelcomIndicatorState.FlashingBlue);
                
                //keep it flashing for 20 seconds (20,000 milliseconds)
                Thread.Sleep(20 * 1000);
            }
            finally
            {
                light.Dispose();
            }
        }
    }
}
