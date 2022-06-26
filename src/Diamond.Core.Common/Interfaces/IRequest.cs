namespace Diamond.Core.Common.Interfaces
{
    public interface IRequest<ObjectModel>
    {
        Guid RequestToken { get; }
        Guid ClientToken { get; }
        Guid? SessionToken { get; }
        Guid? PassportToken { get; }
        DateTime DeliveryTime { get; }
        ObjectModel? RequestObject { get; }
    }
}
