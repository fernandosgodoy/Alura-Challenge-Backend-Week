using AluraFlix.Domain.Base;
using AluraFlix.EFPersistence.Context;
using AluraFlix.EFPersistence.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraFlix.EFPersistence.Base
{
    public abstract class RepositoryBase<TEntity>
        : IRepository<TEntity>
        where TEntity : EntityBase
    {

        private readonly AluraFlixDbContext _aluraFlixDbContext;

        public RepositoryBase(AluraFlixDbContext aluraFlixDbContext)
        {
            this._aluraFlixDbContext = aluraFlixDbContext;
        }

        public bool Add(TEntity entity)
        {
            _aluraFlixDbContext.Set<TEntity>().Add(entity);
            _aluraFlixDbContext.SaveChanges();
            return (entity.Id > 0);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _aluraFlixDbContext.Set<TEntity>().ToArray();
        }

        public TEntity GetById(int id)
        {
            return _aluraFlixDbContext.Set<TEntity>().Find(id);
        }

        public void RemoveById(int id)
        {
            var entityToRemove = this.GetById(id);
            if (entityToRemove != null)
            {
                _aluraFlixDbContext.Attach<TEntity>(entityToRemove);
                _aluraFlixDbContext.Entry(entityToRemove).State = EntityState.Modified;
                _aluraFlixDbContext.Set<TEntity>().Remove(entityToRemove);
            }
        }

        public void Update(TEntity entity)
        {
            _aluraFlixDbContext.Attach<TEntity>(entity);
            _aluraFlixDbContext.Entry(entity).State = EntityState.Modified;
            _aluraFlixDbContext.Update(entity);
        }
    }
}
