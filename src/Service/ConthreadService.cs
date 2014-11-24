using System.Collections.Generic;
using System.Linq;

namespace Likja.Conthread
{
    public class ConthreadService<T> : IConthreadService<T>
        where T : Conthread
    {
        private IConthreadRepository<T> _conthreadRepository;

        public ConthreadService(IConthreadRepository<T> conthreadRepository)
        {
            _conthreadRepository = conthreadRepository;
        }

        public IEnumerable<T> GetAll()
        {
            return _conthreadRepository.FindAll();
        }

        public T GetById(int id)
        {
            return _conthreadRepository.FindById(id);
        }

        public int Save(T entity)
        {
            return _conthreadRepository.Add(entity);
        }

        public T GetNext(int id)
        {
            var nextItem = _conthreadRepository.FindAll()
                .Where(x => x.Id > id).OrderBy(x => x.Id).FirstOrDefault();

            return nextItem;

        }

        public T GetPrevious(int id)
        {
            var prevItem = _conthreadRepository.FindAll()
                .Where(x => x.Id < id).OrderByDescending(x => x.Id).FirstOrDefault();

            return prevItem;
        }

    }
}
