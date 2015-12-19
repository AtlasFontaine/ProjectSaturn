using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Saturn.BLL.Repository
{
    interface IRepository<T>:IDisposable where T: class
    {
        void Update(T Entity);
        void Delete(T Entity);
        void Insert(T Entity);
        List<T> SelectByAll();
        T SelectByQuery(Expression<Func<T, bool>> query);
    }
}
