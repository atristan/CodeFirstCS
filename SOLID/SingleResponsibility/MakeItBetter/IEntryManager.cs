namespace SOLID.SingleResponsibility
{
    public interface IEntryManager<in T>
    {
        void AddEntry(T entry);
        void RemoveEntryAt(int idx);
    }
}
