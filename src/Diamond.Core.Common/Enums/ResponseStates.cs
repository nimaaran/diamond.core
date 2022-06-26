namespace Diamond.Core.Common.Enums;

public enum ResponseStates : byte
{
    NotSet = 0,
    Pending = 5,
    Rejected = 10,
    Processing = 15,
    Done = 20,
    Failed = 25,
    Queued = 30,
}
