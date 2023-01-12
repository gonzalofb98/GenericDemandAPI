using Dto.Request;
using Dto.Response;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IGenericServiceAsync<Entity,T, P> where T : class where Entity : EntityBase
    {
        Task<ICollection<T>> ListAsync();

        Task<T> GetByIdAsync(int id);

        Task<int> CreateAsync(P request);

        Task<int> UpdateAsync(int id, P request);

        Task DeleteAsync(int id);

        Task<ICollection<T>> GetFilter(Expression<Func<Entity, bool>> predicate);

        Task DeleteRange(IEnumerable<P> elements);
    }
}
