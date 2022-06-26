using Diamond.Core.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Core.Common.Abstracts
{
    public abstract class AbstractService<RequestModel, ResponseModel> : IService<RequestModel, ResponseModel>
    {
        public abstract IResponse<ResponseModel> Process(IRequest<RequestModel> request);
    }
}
