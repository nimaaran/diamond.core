using Diamond.Core.Common.Interfaces;

namespace Diamond.Core.Common.Abstracts;

public abstract class AbstractServiceRequest<Model> : IRequest<Model> where Model : class
{
    public Guid RequestToken { get; protected set; } = Guid.Empty;
    public Guid ClientToken { get; protected set; } = Guid.Empty;
    public Guid? SessionToken { get; protected set; } = null;
    public Guid? PassportToken { get; protected set; } = null;
    public DateTime DeliveryTime { get; protected set; } = DateTime.Now;
    public Model? RequestObject { get; protected set; } = null;
}
