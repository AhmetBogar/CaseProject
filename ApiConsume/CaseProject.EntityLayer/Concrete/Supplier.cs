using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseProject.EntityLayer.Concrete
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string AssociationNo { get; set; }
        public List<Order> Orders { get; set; }
    }
}
