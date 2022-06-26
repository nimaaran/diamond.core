using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Core.Common.Interfaces;

public interface IService<RequestModel, ResponseModel>
{
    IResponse<ResponseModel> Process(IRequest<RequestModel> request);
}
