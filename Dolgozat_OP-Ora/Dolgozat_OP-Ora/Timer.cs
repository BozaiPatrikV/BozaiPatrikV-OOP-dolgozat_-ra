using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dolgozat_OP_Ora
{
    internal class Timer
    {
        public int remainingSeconds { get; set; }

        public Timer(int seconds)
        {
            remainingSeconds = seconds;
        }

        public void SetTime(int seconds)
        {
            remainingSeconds = seconds;
        }

        public void StartTimer()
        {
            for (int i = remainingSeconds; i >= 0; i--)
            {
                Console.WriteLine($"Hátralévő idő: {i} másodperc");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Az időzítő lejárt!");
        }
    }
}
