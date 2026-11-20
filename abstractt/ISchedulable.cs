using System;

namespace SmartHomeApp
{
    public interface ISchedulable
    {
        TimeSpan? ScheduledOn { get; }
        TimeSpan? ScheduledOff { get; }
        void ScheduleOn(TimeSpan time);
        void ScheduleOff(TimeSpan time);
    }
}
