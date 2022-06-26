using Diamond.Core.Common.Interfaces;

namespace Diamond.Core.Common.Abstracts;

public abstract class AbstractCollectionAssociation<T> : List<T>, ICollectionAssociation<T>
{
    public IKey? Key { get; protected set; }

    public bool Initialized { get; protected set; }

    public IEnumerable<T>? Collection { get; protected set; }

}
