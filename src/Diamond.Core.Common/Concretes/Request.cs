using Diamond.Core.Common.Abstracts;

namespace Diamond.Core.Common.Concretes;

public class Request<Model> : AbstractServiceRequest<Model> where Model : class
{
}
