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
    public class SupplierManager : ISupplierService
    {
        private readonly ISupplierDal _supplierDal;

        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }

        public async Task TDeleteAsync(Supplier t)
        {
            await _supplierDal.DeleteAsync(t);
        }

        public async Task<Supplier> TGetByIdAsync(int id)
        {
            return await _supplierDal.GetByIdAsync(id);
        }

        public async Task<List<Supplier>> TGetListAsync()
        {
            return await _supplierDal.GetListAsync();
        }

        public async Task<List<Supplier>> TGetListByFilter(Expression<Func<Supplier, bool>> filter)
        {
            return await _supplierDal.GetListByFilter(filter);
        }

        public async Task TInsertAsync(Supplier t)
        {
            await _supplierDal.InsertAsync(t);
        }

        public async Task TUpdateAsync(Supplier t)
        {
            await _supplierDal.UpdateAsync(t);
        }
    }
}
