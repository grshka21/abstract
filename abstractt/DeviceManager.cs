using System;
using System.Collections.Generic;

namespace SmartHomeApp
{
    public class DeviceManager
    {
        private readonly List<SmartDevice> _devices = new List<SmartDevice>();

        public void Add(SmartDevice device) => _devices.Add(device);
        public void TurnAllOn() { foreach (var d in _devices) d.TurnOn(); }
        public void PrintAllStatuses() { foreach (var d in _devices) Console.WriteLine(d.GetStatus()); }

        public void SetLevelForAllAdjustable(int level)
        {
            foreach (var d in _devices)
                if (d is IAdjustable a) a.SetLevel(level);
        }

        public void PrintScheduledDevices()
        {
            foreach (var d in _devices)
                if (d is ISchedulable s && (s.ScheduledOn.HasValue || s.ScheduledOff.HasValue))
                    Console.WriteLine($"{d.Name}: вкл в {s.ScheduledOn}, выкл в {s.ScheduledOff}");
        }

        public void PrintTotalEnergy()
        {
            double total = 0;
            foreach (var d in _devices)
                if (d is IEnergyConsumer c) total += c.CalculateDailyConsumption();
            Console.WriteLine($"Суммарное потребление за сутки: {total:F2} кВт·ч");
        }
    }
}
