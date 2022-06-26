using Diamond.Core.Common.Interfaces;

namespace Diamond.Core.Common.Abstracts;

public abstract class AbstractService<RequestModel, ResponseModel> : IService<RequestModel, ResponseModel>
{
    public abstract IResponse<ResponseModel> Process(IRequest<RequestModel> request);
}
