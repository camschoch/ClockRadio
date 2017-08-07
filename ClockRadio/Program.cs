using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            clockRadio runProgram = new clockRadio();
            Console.WriteLine("type one of these to perform the task: time, alarm on, alarm off, set alarm, radio on, radio off, set radio.");
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "time":
                    runProgram.getTime();
                    break;
                case "alarm on":
                    runProgram.setAlarmOn();
                    break;
                case "alarm off":
                    runProgram.setAlarmOff();
                    break;
                case "set alarm":
                    runProgram.setAlarmTime();
                    break;
                case "radio on":
                    runProgram.turnOnRadio();
                    break;
                case "radio off":
                    runProgram.turnOffRadio();
                    break;
                case "set radio":
                    runProgram.setRadioStation();
                    break;
                default:
                    Console.WriteLine("Sorry that did not work");
                    break;
            }
        }
    }
}
