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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public async Task TDeleteAsync(Customer t)
        {
           await _customerDal.DeleteAsync(t);
        }

        public async Task<Customer> TGetByIdAsync(int id)
        {
            return await _customerDal.GetByIdAsync(id);
        }

        public Task<List<Customer>> TGetListAsync()
        {
            return _customerDal.GetListAsync();
        }

        public async Task<List<Customer>> TGetListByFilter(Expression<Func<Customer, bool>> filter)
        {
            return await _customerDal.GetListByFilter(filter);
        }

        public async Task TInsertAsync(Customer t)
        {
           await _customerDal.InsertAsync(t);
        }

        public async Task TUpdateAsync(Customer t)
        {
            await _customerDal.UpdateAsync(t);
        }
    }
}
