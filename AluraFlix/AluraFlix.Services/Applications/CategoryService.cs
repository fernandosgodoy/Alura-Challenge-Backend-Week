using AluraFlix.Domain;
using AluraFlix.EFPersistence.Repositories;
using AluraFlix.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraFlix.Services.Applications
{
    public class CategoryService
        : IService<Category>
    {

        private readonly CategoryRepository _categoryRepository;

        public CategoryService(CategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public bool Delete(int id)
        {
            var deleted = false;
            try
            {
                _categoryRepository.RemoveById(id);
                deleted = true;
            }
            catch (Exception)
            {
                throw;
            }
            return deleted;
        }

        public Category FindById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public bool Insert(Category entity)
        {
            var inserted = false;
            try
            {
                inserted = _categoryRepository.Add(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return inserted;
        }

        public IEnumerable<Category> ListAll()
        {
            return _categoryRepository.GetAll();
        }

        public bool Update(int id, Category entity)
        {
            var updated = false;
            try
            {
                entity.Id = id;
                _categoryRepository.Update(entity);
                updated = true;
            }
            catch (Exception)
            {
                throw;
            }
            return updated;
        }
    }
}
