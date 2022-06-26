namespace Diamond.Core.Common.Interfaces
{
    public interface ICollectionAssociation<T> : IEnumerable<T>
    {
        IKey? Key { get; }
        bool Initialized { get; }
        IEnumerable<T>? Collection { get; }
    }
}
