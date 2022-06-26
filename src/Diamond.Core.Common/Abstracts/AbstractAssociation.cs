using Diamond.Core.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Core.Common.Abstracts
{
    public abstract class AbstractAssociation<T> : IAssociation<T>
    {
        public IKey? Key { get; protected set; }

        public bool Initialized { get; protected set; }

        public T? Association { get; protected set; }
    }
}
