using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CaseProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task TInsertAsync(T t);
        Task TDeleteAsync(T t);
        Task TUpdateAsync(T t);
        Task<T> TGetByIdAsync(int id);
        Task<List<T>> TGetListAsync();
        Task<List<T>> TGetListByFilter(Expression<Func<T, bool>> filter);
    }
}
