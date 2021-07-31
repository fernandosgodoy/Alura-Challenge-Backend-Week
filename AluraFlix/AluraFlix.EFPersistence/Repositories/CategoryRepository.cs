using AluraFlix.Domain;
using AluraFlix.EFPersistence.Base;
using AluraFlix.EFPersistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraFlix.EFPersistence.Repositories
{
    public class CategoryRepository
        : RepositoryBase<Category>
    {
        public CategoryRepository(AluraFlixDbContext aluraFlixDbContext) 
            : base(aluraFlixDbContext)
        {
        }
    }
}
