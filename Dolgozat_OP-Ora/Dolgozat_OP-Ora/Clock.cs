using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_OP_Ora
{
    internal class Clock
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
        public string timezone { get; set; }
        public bool is24HourFormat { get; set; }

        public Clock(int hour, int minute, int second, string timezone, bool is24HourFormat)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            this.timezone = timezone;
            this.is24HourFormat = is24HourFormat;
        }

        public void SetTime(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public void DisplayTime()
        {
            string timeFormat = is24HourFormat ? "HH:mm:ss" : "h:mm:ss tt";
            string formattedTime = DateTime.Now.ToString(timeFormat) + " " + timezone;
            Console.WriteLine(formattedTime);
        }

        public void SetTimeZone(string timezone)
        {
            this.timezone = timezone;
        }

        public void ToggleTimeFormat()
        {
            is24HourFormat = !is24HourFormat;
        }
    }
}
