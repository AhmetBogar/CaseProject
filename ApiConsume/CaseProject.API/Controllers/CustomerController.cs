using AutoMapper;
using CaseProject.BusinessLayer.Abstract;
using CaseProject.DtoLayer.Dtos.Customer;
using CaseProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var values=await _customerService.TGetListAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult>GetCustomerById(int id)
        {
            var value=await _customerService.TGetByIdAsync(id);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult>AddCustomer(CreateCustomerDto createCustomerDto)
        {
            var value = _mapper.Map<Customer>(createCustomerDto);
            await _customerService.TInsertAsync(value);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult>DeleteCustomer(int id)
        {
            var value = await _customerService.TGetByIdAsync(id);
            await _customerService.TDeleteAsync(value);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult>UpdateCustomer(UpdateCustomerDto updateCustomerDto)
        {
            var value=_mapper.Map<Customer>(updateCustomerDto);
            await _customerService.TUpdateAsync(value);
            return Ok();
        }
    }
}
