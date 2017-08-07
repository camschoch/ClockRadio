using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class clockRadio
    {
        bool alarmStatus;
        public void getTime()
        {
            Console.WriteLine("07:30");
            Console.ReadLine();
        }
        public void setAlarmOn()
        {
            Console.WriteLine("Alarm is on");
            Console.ReadLine();
        }
        public void setAlarmOff()
        {
            Console.WriteLine("Alarm is off");
            Console.ReadLine();
        }

        public void setAlarmTime()
        {
            Console.WriteLine("enter the time you would like to set the alarm to.");
            string alarmTime = Console.ReadLine();
            Console.WriteLine("The alarm is set to " + alarmTime);
            Console.ReadLine();
        }
        public void setRadioStation()
        {
            Console.WriteLine("enter the radio station you would like to set the radio to.");
            string radioStation = Console.ReadLine();
            Console.WriteLine("The radio station is set to " + radioStation);
            Console.ReadLine();
        }
        public void turnOnRadio()
        {
            Console.WriteLine("Radio is on");
            Console.ReadLine();
        }
        public void turnOffRadio()
        {
            Console.WriteLine("Radio is off");
            Console.ReadLine();
        }


    }
}
