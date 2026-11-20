namespace SmartHomeApp
{
    public interface IAdjustable
    {
        int Level { get; }
        void SetLevel(int level);
    }
}
