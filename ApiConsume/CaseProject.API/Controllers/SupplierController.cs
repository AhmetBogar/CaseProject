using AutoMapper;
using CaseProject.BusinessLayer.Abstract;
using CaseProject.DtoLayer.Dtos.Supplier;
using CaseProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaseProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;
        private readonly IMapper _mapper;

        public SupplierController(ISupplierService supplierService, IMapper mapper)
        {
            _supplierService = supplierService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSuppliers()
        {
            var values = await _supplierService.TGetListAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult>AddSupplier(CreateSupplierDto createSupplierDto)
        {
            var value=_mapper.Map<Supplier>(createSupplierDto);
            await _supplierService.TInsertAsync(value);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult>DeleteSupplier(int id)
        {
            var value=await _supplierService.TGetByIdAsync(id);
            await _supplierService.TDeleteAsync(value);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult>UpdateSupplier(UpdateSupplierDto updateSupplierDto)
        {
            var value = _mapper.Map<Supplier>(updateSupplierDto);
            await _supplierService.TUpdateAsync(value);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSupplierById(int id)
        {
            var value = await _supplierService.TGetByIdAsync(id);
            return Ok(value);
        }
    }
}
