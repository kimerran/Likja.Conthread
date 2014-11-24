using Likja.DataAccess.Common;

namespace Likja.Conthread
{
    public class ConthreadRepository<T> : BaseRepository<T>, IConthreadRepository<T>
        where T : Conthread
    {
        private IUnitOfWork _uow;
        public ConthreadRepository(IUnitOfWork uow) : base(uow)
        {
            _uow = uow;
        }
    }
}
