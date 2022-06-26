using Diamond.Core.Common.Enums;
using Diamond.Core.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Core.Common.Abstracts
{
    public abstract class AbstractServiceResponse<Model> : IResponse<Model> where Model : class
    {
        public Guid ResponseToken {get; protected set;} = Guid.Empty;
        public long ResponseCode { get; protected set; } = 0;
        public string ResponseNote { get; protected set; } = string.Empty;
        public Model? ResponseObject { get; protected set; } = null;
        public ResponseStates ResponseState { get; protected set; } = ResponseStates.NotSet;
        public IEnumerable<string> ResponseParameters { get; protected set; } = new List<string>();
    }
}
