using Likja.DataAccess.Common;

namespace Likja.Conthread
{
    public interface IConthreadRepository<T> : IBaseRepository<T>
        where T : Conthread
    {
    }
}
