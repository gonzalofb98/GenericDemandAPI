using AutoMapper;
using DataAccess.Repositories;
using Dto.Request;
using Dto.Response;
using Entities;
using Services.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class CustomerService : GenericServiceAsync<Customer,DtoCustomerResponse,DtoCustomerRequest>, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository curtomerRepository,IMapper mapper)  : base(curtomerRepository,mapper)
        {
            _customerRepository = curtomerRepository;
            _mapper = mapper;   
        }

        public async Task<ICollection<DtoCustomerDirections>> GetDirectionsAsync(int id)
        {
            var collection = await _customerRepository.ListDirections(id);
            return _mapper.Map<ICollection<Direction>, ICollection<DtoCustomerDirections>>(collection);
        }
    }
}
