using System;

namespace SmartHomeApp
{
    public class SmartThermostat : SmartDevice, IAdjustable, ISchedulable
    {
        public int TargetTemperature { get; private set; } = 22;
        public TimeSpan? ScheduledOn { get; private set; }
        public TimeSpan? ScheduledOff { get; private set; }

        public SmartThermostat(string id, string name) : base(id, name) { }

        public int Level => TargetTemperature;
        public void SetLevel(int level) => TargetTemperature = level;
        public void ScheduleOn(TimeSpan time) => ScheduledOn = time;
        public void ScheduleOff(TimeSpan time) => ScheduledOff = time;

        public override string GetStatus() =>
            $"Термостат [{Name}]: {(IsOn ? "вкл" : "выкл")}, цель {TargetTemperature}°C";
    }
}
