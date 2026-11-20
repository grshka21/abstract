using System;

namespace SmartHomeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var light = new SmartLight("L1", "Лампа");
            light.ScheduleOn(new TimeSpan(8, 0, 0));
            light.ScheduleOff(new TimeSpan(23, 0, 0));

            var thermostat = new SmartThermostat("T1", "Термостат");
            thermostat.ScheduleOn(new TimeSpan(7, 30, 0));

            var manager = new DeviceManager();
            manager.Add(light);
            manager.Add(thermostat);
            manager.Add(new SmartFan("F1", "Вентилятор"));

            manager.TurnAllOn();
            manager.SetLevelForAllAdjustable(4);
            manager.PrintAllStatuses();
            manager.PrintScheduledDevices();

            Console.ReadKey();
        }
    }
}
