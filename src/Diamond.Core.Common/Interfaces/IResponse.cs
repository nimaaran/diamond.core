using Diamond.Core.Common.Enums;

namespace Diamond.Core.Common.Interfaces;

public interface IResponse<ObjectModel>
{
    Guid ResponseToken { get; }
    long ResponseCode { get; }
    string ResponseNote { get; }
    ObjectModel? ResponseObject { get; }
    ResponseStates ResponseState { get; }
    IEnumerable<string> ResponseParameters { get; }
}
