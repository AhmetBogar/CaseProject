using CaseProject.DataAccessLayer.Abstract;
using CaseProject.DataAccessLayer.Concrete;
using CaseProject.DataAccessLayer.Repositories;
using CaseProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseProject.DataAccessLayer.EntityFramework
{
    public class EfSupplierDal : GenericRepository<Supplier>, ISupplierDal
    {
        public EfSupplierDal(Context context) : base(context)
        {
        }
    }
}
