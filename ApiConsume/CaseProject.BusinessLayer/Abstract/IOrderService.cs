using CaseProject.DtoLayer.Dtos.Order;
using CaseProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseProject.BusinessLayer.Abstract
{
    public interface IOrderService : IGenericService<Order>
    {
        Task<List<ResultOrderDto>> GetOrdersWithDetails();
        Task<ResultOrderDto> GetOrderDetailsById(int orderId);
    }
}
