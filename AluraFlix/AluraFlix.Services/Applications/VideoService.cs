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
    public class VideoService
        : IService<Video>
    {

        private readonly VideoRepository _videoRepository;
        public VideoService(VideoRepository videoRepository)
        {
            this._videoRepository = videoRepository;
        }

        public bool Delete(int id)
        {
            var deleted = false;
            try
            {
                _videoRepository.RemoveById(id);
                deleted = true;
            }
            catch (Exception)
            {
                throw;
            }
            return deleted;
        }

        public Video FindById(int id)
        {
            return _videoRepository.GetById(id);
        }

        public bool Insert(Video entity)
        {
            var inserted = false;
            try
            {
                inserted = _videoRepository.Add(entity);
            }
            catch (Exception)
            {
                throw;
            }
            return inserted;
        }

        public IEnumerable<Video> ListAll()
        {
            return _videoRepository.GetAll();
        }

        public bool Update(Video entity)
        {
            var updated = false;
            try
            {
                _videoRepository.Update(entity);
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
