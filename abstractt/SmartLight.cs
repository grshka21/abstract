using System;

namespace SmartHomeApp
{
    public class SmartLight : SmartDevice, IAdjustable, ISchedulable
    {
        public int Brightness { get; private set; } = 100;
        public TimeSpan? ScheduledOn { get; private set; }
        public TimeSpan? ScheduledOff { get; private set; }

        public SmartLight(string id, string name) : base(id, name) { }

        public int Level => Brightness;
        public void SetLevel(int level) => Brightness = level;
        public void ScheduleOn(TimeSpan time) => ScheduledOn = time;
        public void ScheduleOff(TimeSpan time) => ScheduledOff = time;

        public override string GetStatus() =>
            $"Лампа [{Name}]: {(IsOn ? "вкл" : "выкл")}, яркость {Brightness}%";
        public double PowerConsumptionWatt => 10;
        public double CalculateDailyConsumption() => PowerConsumptionWatt * 8 / 1000.0;

    }
}
