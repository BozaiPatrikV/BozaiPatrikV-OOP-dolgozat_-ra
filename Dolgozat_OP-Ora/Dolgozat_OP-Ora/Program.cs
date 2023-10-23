using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_OP_Ora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock ido = new Clock(12, 30, 45, "UTC+2", true);

            List<Alarm> alarm = new List<Alarm>();
            Console.Write("Add meg az 1. ébresztés óráját: ");
            int alarmOra = int.Parse(Console.ReadLine());
            Console.Write("Add meg az 1. ébresztés percét: ");
            int alarmPerc = int.Parse(Console.ReadLine());
            alarm.Add(new Alarm(alarmOra, alarmPerc));

            Console.Write("Add meg az 2. ébresztés óráját: ");
            alarmOra = int.Parse(Console.ReadLine());
            Console.Write("Add meg az 2. ébresztés percét: ");
            alarmPerc = int.Parse(Console.ReadLine());
            alarm.Add(new Alarm(alarmOra, alarmPerc));

            Console.WriteLine();
            //Console.WriteLine($"{alarm.Count}");
            Timer myTimer = new Timer(10);

            ido.DisplayTime();

            foreach (var item in alarm)
            {
                if (item.IsAlarmTime(ido.hour, ido.minute))
                {
                    Console.WriteLine("Az ébresztő megszólalt!");
                }
            }

            Console.WriteLine();

            myTimer.StartTimer();
            

            Console.ReadKey();
        }
    }
}
