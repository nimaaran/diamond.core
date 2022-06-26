using Diamond.Core.Common.Abstracts;
using Diamond.Core.Common.Interfaces;

namespace Diamond.Core.Common.Concretes;

public class Key : AbstractKey
{
    public static IKey Empty { get { return new Key(); } }
}
