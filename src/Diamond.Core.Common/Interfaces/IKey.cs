using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Core.Common.Interfaces
{
    public interface IKey
    {
        bool IsEmpty { get; }
        Type KeyType { get; }
        object? Value { get; }
        T? Get<T>();
        IKey Set<T>(T key);
        IKey ClearKey();
    }
}
