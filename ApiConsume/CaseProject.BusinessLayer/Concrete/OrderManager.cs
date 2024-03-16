using CaseProject.BusinessLayer.Abstract;
using CaseProject.DataAccessLayer.Abstract;
using CaseProject.DataAccessLayer.Concrete;
using CaseProject.DtoLayer.Dtos.Order;
using CaseProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CaseProject.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly Context _context;
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal, Context context)
        {
            _orderDal = orderDal;
            _context = context;
        }

        public async Task TDeleteAsync(Order t)
        {
            await _orderDal.DeleteAsync(t);
        }

        public async Task<Order> TGetByIdAsync(int id)
        {
            return await _orderDal.GetByIdAsync(id);
        }

        public async Task<List<Order>> TGetListAsync()
        {
            return await _orderDal.GetListAsync();
        }

        public async Task<List<Order>> TGetListByFilter(Expression<Func<Order, bool>> filter)
        {
            return await _orderDal.GetListByFilter(filter);
        }

        public async Task TInsertAsync(Order t)
        {
             await _orderDal.InsertAsync(t);
        }

        public async Task TUpdateAsync(Order t)
        {
            await _orderDal.UpdateAsync(t);
        }
        public async Task<List<ResultOrderDto>> GetOrdersWithDetails()
        {
            var orders = await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Supplier)
                .Select(o => new ResultOrderDto
                {
                    OrderId = o.OrderId,
                    CustomerName=o.Customer.CustomerName,
                    CustomerId=o.Customer.CustomerId,
                    SupplierId=o.SupplierId,
                    SupplierName=o.Supplier.SupplierName,
                    CreatedDate=o.CreatedDate,
                    OBJKEY=o.OBJKEY,
                    AssociationNo=o.Supplier.AssociationNo                    
                })
                .ToListAsync();

            return orders;
        }
    }
}
