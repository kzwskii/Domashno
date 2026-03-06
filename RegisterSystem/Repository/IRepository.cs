using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterSystem.Repository;

public interface IRepository<TEntity>
{
    List<TEntity> GetAll();
    TEntity GetById(int id);
    void Add(TEntity entity);
    void Update(int id);
    void Delete(int id);
}
