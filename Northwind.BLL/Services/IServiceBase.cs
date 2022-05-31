using Northwind.BLL.Helpers;
using Northwind.DAL.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL.Services
{
    public interface IServiceBase<T1,T2> where T1 : class 
    {
        Task<ProcessedResponse> AddAsync(T1 entity);

        Task<ProcessedResponse> GetAsync(T2 id);

        Task<ProcessedResponse> GetListAsync(int pageNumber, int numberOfRows);

        Task<ProcessedResponse> GetListAsync(Expression<Func<T1, bool>> expression, int pageNumber, int numberOfRows);

        Task<ProcessedResponse> UpdateAsync(T1 entity);

        Task<ProcessedResponse> DeleteAsync(T2 entity);

        Task<ProcessedResponse> AnyAsync(Expression<Func<T1, bool>> expression);
    }
}
