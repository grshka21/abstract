namespace SmartHomeApp
{
    public interface IEnergyConsumer
    {
        double PowerConsumptionWatt { get; }
        double CalculateDailyConsumption();
    }
}
