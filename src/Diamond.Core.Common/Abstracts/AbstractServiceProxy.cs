using Diamond.Core.Common.Interfaces;

namespace Diamond.Core.Common.Abstracts;

public abstract class AbstractServiceProxy<RequestModel, ResponseModel> : IServiceProxy<RequestModel, ResponseModel>
{
    public abstract IResponse<ResponseModel> Process(IRequest<RequestModel> request);
}
