using Diamond.Core.Common.Interfaces;
using System.Linq.Expressions;

namespace Diamond.Core.Common.Abstracts;

public abstract class AbstractDataProvider<Entity, KeyType> : IDataProvider<Entity>
{
    public abstract Entity Create(Entity entity);
    public abstract Entity Read(IKey key);
    public abstract Entity Update(Entity entity);
    public abstract bool Delete(IKey key);
    public abstract bool Delete(Entity entity);
    public abstract IEnumerable<Entity> CreateMany(Entity[] entities);
    public abstract IEnumerable<Entity> ReadMany(IKey[] keys);
    public abstract IEnumerable<Entity> UpdateMany(Entity[] entities);
    public abstract IEnumerable<Entity> DeleteMany(IKey[] keys);
    public abstract IEnumerable<Entity> DeleteMany(Entity[] entities);
    public abstract IEnumerable<Entity> Query(Expression<Func<Entity, bool>> predicate);
}
