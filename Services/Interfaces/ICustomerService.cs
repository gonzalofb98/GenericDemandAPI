using System.Collections.Generic;
using System.Threading.Tasks;
using Dto.Request;
using Dto.Response;
using Entities;

namespace Services.Interfaces
{
    public interface ICustomerService : IGenericServiceAsync<Customer,DtoCustomerResponse, DtoCustomerRequest>
    {
        Task<ICollection<DtoCustomerDirections>> GetDirectionsAsync(int id);
    }
}