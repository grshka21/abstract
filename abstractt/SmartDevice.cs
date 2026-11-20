namespace SmartHomeApp
{
    public abstract class SmartDevice
    {
        public string Id { get; }
        public string Name { get; set; }
        public bool IsOn { get; protected set; }

        protected SmartDevice(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public virtual void TurnOn() { IsOn = true; }
        public virtual void TurnOff() { IsOn = false; }
        public abstract string GetStatus();
    }

    public class SmartLight : SmartDevice, IAdjustable
    {
        public int Brightness { get; private set; } = 100;
        public SmartLight(string id, string name) : base(id, name) { }
        public int Level => Brightness;
        public void SetLevel(int level) => Brightness = level;
        public override string GetStatus() => $"Лампа [{Name}]: {(IsOn ? "вкл" : "выкл")}, яркость {Brightness}%";
    }

    public class SmartThermostat : SmartDevice, IAdjustable
    {
        public int TargetTemperature { get; private set; } = 22;
        public SmartThermostat(string id, string name) : base(id, name) { }
        public int Level => TargetTemperature;
        public void SetLevel(int level) => TargetTemperature = level;
        public override string GetStatus() => $"Термостат [{Name}]: {(IsOn ? "вкл" : "выкл")}, цель {TargetTemperature}°C";
    }
}
