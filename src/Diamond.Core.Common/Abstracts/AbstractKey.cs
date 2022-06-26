using Diamond.Core.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Core.Common.Abstracts
{
    public abstract class AbstractKey : IKey
    {
        public bool IsEmpty { get; private set; } = true;

        public Type KeyType { get; private set; } = typeof(object);

        public object? Value { get; private set; } = null;  

        public IKey ClearKey()
        {
            IsEmpty = true;
            KeyType = typeof(object);
            Value = null;   

            return this;
        }

        public T? Get<T>()
        {
            if (IsEmpty)
                return default;

            return (T)Value!;
        }

        public IKey Set<T>(T key)
        {
            IsEmpty = false;
            Value = key;
            KeyType = typeof(T);

            return this;
        }

        public AbstractKey()
        {
            ClearKey(); 
        }
    }
}
