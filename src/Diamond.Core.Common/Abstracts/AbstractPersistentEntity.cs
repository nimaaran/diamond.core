using Diamond.Core.Common.Interfaces;

namespace Diamond.Core.Common.Abstracts;

public abstract class AbstractPersistentEntity : AbstractEntity, IPersistentEntity
{
    public int HashCode { get; set; } = default;

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
