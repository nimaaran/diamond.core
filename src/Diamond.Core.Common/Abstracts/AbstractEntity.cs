using Diamond.Core.Common.Concretes;
using Diamond.Core.Common.Enums;
using Diamond.Core.Common.Interfaces;

namespace Diamond.Core.Common.Abstracts;

public abstract class AbstractEntity : IEntity
{
    public IKey Id { get; set; } = Key.Empty;

    public bool IsValid(DataOperations operation)
    {
        switch (operation)
        {
            case DataOperations.Create:
                if (Id.IsEmpty)
                    return false;
                break;

            case DataOperations.Read:

                break;
            case DataOperations.Update:
                if (Id.IsEmpty == false)
                    return false;

                break;
            case DataOperations.Delete:
                if (Id.IsEmpty == false)
                    return false;

                break;
            case DataOperations.Command:

                break;
            default: return false;
        }

        return true;
    }
}
