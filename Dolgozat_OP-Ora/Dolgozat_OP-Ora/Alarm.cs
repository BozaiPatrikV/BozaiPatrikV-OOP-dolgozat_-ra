using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_OP_Ora
{
    internal class Alarm
    {
        public int alarmHour { get; set; }
        public int alarmMinute { get; set; }
        public bool isAlarmOn { get; set; }

        public Alarm(int hour, int minute)
        {
            alarmHour = hour;
            alarmMinute = minute;
            isAlarmOn = false;
        }

        public void SetAlarm(int hour, int minute)
        {
            alarmHour = hour;
            alarmMinute = minute;
        }

        public void TurnOnAlarm()
        {
            isAlarmOn = true;
        }

        public void TurnOffAlarm()
        {
            isAlarmOn = false;
        }

        public bool IsAlarmTime(int hour, int minute)
        {
            return isAlarmOn && hour == alarmHour && minute == alarmMinute;
        }
    }
}
