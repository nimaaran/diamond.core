using Diamond.Core.Common.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Core.Common.Concretes
{
    public class Request<Model> : AbstractServiceRequest<Model> where Model : class
    {
    }
}
