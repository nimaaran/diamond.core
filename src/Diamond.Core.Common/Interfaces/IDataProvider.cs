using System.Linq.Expressions;

namespace Diamond.Core.Common.Interfaces;

public interface IDataProvider<Entity>
{
    Entity Create(Entity entity);
    Entity Read(IKey key);
    Entity Update(Entity entity);
    bool Delete(IKey key);
    bool Delete(Entity entity);
    IEnumerable<Entity> CreateMany(Entity[] entities);
    IEnumerable<Entity> ReadMany(IKey[] keys);
    IEnumerable<Entity> UpdateMany(Entity[] entities);
    IEnumerable<Entity> DeleteMany(IKey[] keys);
    IEnumerable<Entity> DeleteMany(Entity[] entities);
    
    IEnumerable<Entity> Query(Expression<Func<Entity, bool>> predicate);
}
