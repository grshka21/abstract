using System;

namespace SmartHomeApp
{
    public class SmartFan : SmartDevice, IAdjustable
    {
        public int Speed { get; private set; }

        public SmartFan(string id, string name) : base(id, name) { }

        public int Level => Speed;

        public void SetLevel(int level)
        {
            if (level < 0 || level > 5)
                throw new ArgumentOutOfRangeException(nameof(level), "Скорость от 0 до 5");
            Speed = level;
        }

        public override string GetStatus() =>
            $"Вентилятор [{Name}]: {(IsOn ? "вкл" : "выкл")}, скорость {Speed}";
    }
}
