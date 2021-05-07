using System.Collections.Generic;

namespace memory_app.Interfaces
{
    public interface IRepository<T>
    {
        List<T> List();
        T ReturnForId(int id);
        void Insert(T entity);
        void Delete(int id);
        void Update(int id, T entity);
        int NextId();
    }
}