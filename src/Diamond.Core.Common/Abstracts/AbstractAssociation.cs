using Diamond.Core.Common.Interfaces;

namespace Diamond.Core.Common.Abstracts;

public abstract class AbstractAssociation<T> : IAssociation<T>
{
    public IKey? Key { get; protected set; }

    public bool Initialized { get; protected set; }

    public T? Association { get; protected set; }
}
