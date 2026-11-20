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
    }
}
