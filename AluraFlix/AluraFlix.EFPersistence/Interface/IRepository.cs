using AluraFlix.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraFlix.EFPersistence.Interface
{
    public interface IRepository<TEntity>
        where TEntity : EntityBase
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById();
        int Add(TEntity entity);
        void Update(TEntity entity);
        void RemoveById(TEntity entity);
    }
}
