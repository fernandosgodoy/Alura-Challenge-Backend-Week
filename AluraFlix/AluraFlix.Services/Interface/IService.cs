using AluraFlix.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AluraFlix.Services.Interface
{
    public interface IService<TEntity>
        where TEntity : EntityBase
    {
        IEnumerable<TEntity> ListAll();
        TEntity FindById(int id);
        bool Insert(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(int id);
    }
}
