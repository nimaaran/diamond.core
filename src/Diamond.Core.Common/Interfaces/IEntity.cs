using Diamond.Core.Common.Enums;

namespace Diamond.Core.Common.Interfaces;

public interface IEntity
{
    IKey Id { get; set; }

    bool IsValid(DataOperations operation);
}
