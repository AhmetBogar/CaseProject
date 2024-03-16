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
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        public EfOrderDal(Context context) : base(context)
        {
        }
    }
}
