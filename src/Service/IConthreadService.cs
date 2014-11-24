using System.Collections.Generic;

namespace Likja.Conthread
{
    public interface IConthreadService<T>
        where T : Conthread
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        int Save(T entity);
        T GetNext(int id);
        T GetPrevious(int id);
    }
}
