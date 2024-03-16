using CaseProject.BusinessLayer.Abstract;
using CaseProject.DataAccessLayer.Abstract;
using CaseProject.EntityLayer.Concrete;
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
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
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
    }
}
