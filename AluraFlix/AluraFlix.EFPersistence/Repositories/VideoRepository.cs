using AluraFlix.Domain;
using AluraFlix.EFPersistence.Base;
using AluraFlix.EFPersistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraFlix.EFPersistence.Repositories
{
    public class VideoRepository
        : RepositoryBase<Video>
    {

        public VideoRepository(AluraFlixDbContext aluraFlixDbContext) 
            : base(aluraFlixDbContext) { }
    }
}
