namespace Diamond.Core.Common.Interfaces;

public interface IAssociation<T>
{
    IKey? Key { get; }
    bool Initialized { get; }
    T? Association { get; }
}
