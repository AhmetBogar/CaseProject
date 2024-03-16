using AutoMapper;
using CaseProject.DtoLayer.Dtos.Supplier;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CaseProject.Web.Controllers
{
    public class SupplierController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IMapper _mapper;

        public SupplierController(IHttpClientFactory httpClientFactory, IMapper mapper)
        {
            _httpClientFactory = httpClientFactory;
            _mapper = mapper;
        }
        public async Task<IActionResult> SupplierList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5062/api/Supplier");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSupplierDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateSupplier()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateSupplier(CreateSupplierDto createSupplierDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createSupplierDto);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5062/api/Supplier", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("SupplierList");
            }
            return View();
        }
        public async Task<IActionResult> DeleteSupplier(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("http://localhost:5062/api/Supplier?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("SupplierList");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateSupplier(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5062/api/Supplier/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateSupplierDto>(jsonData);
                return View(values);
            }
            return RedirectToAction("SupplierList");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSupplier(UpdateSupplierDto updateSupplierDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateSupplierDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:5062/api/Supplier", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("SupplierList");
            }
            return View();
        }

    }
}
