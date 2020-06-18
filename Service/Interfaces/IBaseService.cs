using System.Collections.Generic;

namespace Service.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        TEntity GetById(long id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);
        
        void Remove(TEntity obj);
        
        void Dispose();
    }
}