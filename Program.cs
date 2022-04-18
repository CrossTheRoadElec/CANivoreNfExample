using System;
using System.Diagnostics;
using System.Threading;
using CTRE;

namespace CANivoreNfExample
{
    public class Program
    {
        public static void Main()
        {
            Debug.WriteLine("Hello from nanoFramework!");

            CANivore can = new CANivore();
            while(true)
            {
                /* Continually send this frame once every 100ms */
                can.SendCan(new CanFrame(0x7762, new byte[] { 1, 2, 4, 5, 6, 7, 8 }));
                Thread.Sleep(100);
            }
        }
    }
}
